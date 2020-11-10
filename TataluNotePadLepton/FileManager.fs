module FileManager

open System.Windows.Forms

exception CancleException of string

let open_save_file_dialog _ = 
    use save_file_dialog = new SaveFileDialog()

    match save_file_dialog.ShowDialog() with
    | DialogResult.OK |DialogResult.Yes ->
        Some save_file_dialog.FileName
    | _ ->
        None 

let create_new_file _ = 
    match open_save_file_dialog() with
    | Some file_path ->
        Core.File.create file_path            
    | None -> Error ( CancleException "Cancle" )


let open_open_file_dialog _ =

    use open_file_dialog = new OpenFileDialog()

    match open_file_dialog.ShowDialog() with
    | DialogResult.OK | DialogResult.Yes ->
        Some open_file_dialog.FileName
    | _ -> None

let open_file (file_path: string option) (file_mode: System.IO.FileMode) =
    match file_path with
    | Some file_path ->
        Core.File.``open`` file_path file_mode       
    | None -> Error ( CancleException "Cancle" )


    
        