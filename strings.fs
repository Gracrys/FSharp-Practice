module Strings
open System

type System.String with
    member this.Find x = 
        Seq.toList this |> List.filter (fun y -> x = y) |> List.length

    member this.Replicate = 
        Seq.toList this |> List.mapi (fun i s -> s |> string >> String.replicate (i + 1)  ) |> List.fold (+) "" 

(*printf  "%A" <| *)

let soup = "Hello".Replicate 
