module Strings
open System

type System.String with
    member this.Find x = 
        Seq.toList this |> List.filter (fun y -> x = y) |> List.length


printfn "%A" <| "Hello motto".Find 'l'
