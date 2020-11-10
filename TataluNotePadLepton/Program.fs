open System
open GUI
open System.Windows.Forms

type MainForm() as self=  
    inherit BaseForm()

    let mutable _content_has_saved = true
    let mutable _file_path: string option = None

    do
        self.create_new_file_ToolStripMenuItem.Click.Add self.on_creat_new_file_MenuItem_click
        self.open_file_ToolStripMenuItem.Click.Add self.on_open_file_MenuItem_click
        self.save_file_ToolStripMenuItem.Click.Add self.on_save_file_MenuItem_click
        self.content_area_RichTextBox.TextChanged.Add self.on_content_area_RichTextBox_text_changed
        self.save_as_another_file_ToolStripMenuItem.Click.Add self.on_save_as_another_file_MenuItem_click
        self.close_ToolStripMenuItem.Click.Add self.on_close_file_MenuItem_click

        self.update_main_form_title ""
        
    member self.content_has_saved
        with get() = _content_has_saved
        and set value = _content_has_saved <- value

    member self.file_path
        with get() = _file_path
        and set value = _file_path <- value

    member self.update_main_form_title (content: string) = 
        
        let file_describe = 
            match self.file_path with
            | Some file_path ->
                file_path
            | None ->
                "Untitled"

        self.Text <- "TataluNotePadLepton-" + file_describe + content

    member self.on_creat_new_file_MenuItem_click (sender: obj) = 
        match FileManager.open_save_file_dialog() with
        | Some file_path ->
            
            self.file_path <- Some file_path

            match Core.File.create file_path with
            | Ok file_stream ->
                
                match Core.File.read_to_string file_stream with
                | Ok content ->
                    
                    self.content_area_RichTextBox.Text <- content
                    self.content_has_saved <- true
                    self.update_main_form_title ""
                | Error err ->
                    MessageBox.Show (err.ToString()) |> ignore

            | Error err ->
                MessageBox.Show (err.ToString()) |> ignore

        | None -> ()

        ()
       
    member self.on_open_file_MenuItem_click (sender: obj) = 
        match FileManager.open_open_file_dialog() with
        | Some file_path ->
            
            self.file_path <- Some file_path

            match Core.File.``open`` file_path IO.FileMode.Open with
            | Ok file_stream ->
                
                match Core.File.read_to_string file_stream with
                | Ok content ->
                    self.content_area_RichTextBox.Text <- content
                    self.content_has_saved <- true
                    self.update_main_form_title ""
                | Error err ->
                    MessageBox.Show (err.ToString()) |> ignore

            | Error err ->
                MessageBox.Show (err.ToString()) |> ignore
        | None -> ()

        ()

    member self.on_content_area_RichTextBox_text_changed (sender: obj) = 
        match self.content_has_saved with
        | true -> 
            self.content_has_saved <- false
            self.update_main_form_title "-Not Saved"
        | false -> ()
        ()

    member self.on_save_file_MenuItem_click (sender: obj) = 
        match self.content_has_saved with
        | true ->
            ()
        | false ->
            match self.file_path with
            | Some file_path ->
                use stream_write = new IO.StreamWriter (IO.File.OpenWrite file_path)

                stream_write.WriteLine self.content_area_RichTextBox.Text
                self.update_main_form_title ""
                self.content_has_saved <- true
            | None ->
                match FileManager.open_save_file_dialog() with
                | Some file_path ->
                    self.file_path <- Some file_path

                    match Core.File.create file_path with
                    | Ok stream ->
                        use stream_write = new IO.StreamWriter (stream)

                        stream_write.WriteLine self.content_area_RichTextBox.Text
                        self.update_main_form_title ""
                        self.content_has_saved <- true
                    | Error err ->
                        MessageBox.Show (err.ToString()) |> ignore
                | None ->
                    ()

        ()

    member self.on_save_as_another_file_MenuItem_click (sender: obj) = 
        
        match FileManager.open_save_file_dialog() with
        | Some file_path ->
            match Core.File.create file_path with
            | Ok file_stream ->
                use stream_write = new IO.StreamWriter (file_stream)
                
                stream_write.WriteLine self.content_area_RichTextBox.Text
                self.update_main_form_title ""
                self.content_has_saved <- true
            | Error err ->
                MessageBox.Show (err.ToString()) |> ignore
                
        | None -> ()

        ()

    member self.on_close_file_MenuItem_click (sender: obj) = 
        
        self.content_area_RichTextBox.Text <- ""   
        self.content_has_saved <- true
        self.file_path <- None
        self.update_main_form_title ""
        ()


[<STAThread>]
[<EntryPoint>]
let main argv =
    
    let form = new MainForm()

    
    
    Application.EnableVisualStyles()
    Application.Run form 
    0 
