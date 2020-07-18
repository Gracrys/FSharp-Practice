module Strings
open System

type System.String with
    member this.Find x = 
        Seq.toList this |> List.filter (fun y -> x = y) |> List.length

    member this.Replicate = 
        Seq.toList this |> List.mapi (fun s i -> (*String.replicate (String s)*) s )  

printfn "%A" <| "Hello".Replicate 
