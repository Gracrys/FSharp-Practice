module Strings
open System
open System.Text.RegularExpressions

type System.String with
    member this.Find x = 
        Seq.toList this |> List.filter (fun y -> x = y) |> List.length
    member this.Replicate = 
        Seq.toList this |> List.mapi (fun i s -> s |> string |> String.replicate (i + 1) ) |> List.fold (+) "" 
    member this.Sort =
        this |> (Seq.toList >> Seq.sort >> String.Concat)
    member this.isPrefix str =
        Regex.Match(str, this).Success 

let soup = "hello".isPrefix "hello motto" 
