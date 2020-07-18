module Strings
open System

type System.String with
    member this.Find = 
        Seq.toList this 


printfn "%A" <| "Hello motto".Find
