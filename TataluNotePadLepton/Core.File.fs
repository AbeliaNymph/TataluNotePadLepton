module Core.File

open System.IO
open System

let create file_path = 
    try
        Ok (File.Create file_path)
        
    with 
    | :? Exception as err ->
        Error err



let ``open`` file_path (file_mode: FileMode) = 
    try
        Ok (File.Open(file_path, file_mode))
        
    with 
    | :? Exception as err ->
        Error err

let read_to_string (file_stream: FileStream) = 
    use stream_reader = new StreamReader(file_stream)

    try
        Ok (stream_reader.ReadToEnd())
    with
    | :? Exception as err ->
        Error err