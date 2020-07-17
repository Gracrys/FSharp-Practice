module Lists

open System

type MyType = {N : int}
type MyList = int list

let max x y = if x < y then y else x
let min x y = if x > y then y else x

let maxList (x:int list) = List.reduce max x
let minList (x:int list) = List.reduce min x

let removeFst n x = List.filter (fun y -> y <> x) n

let rec srtInts xs =
  let m = minList xs
  match xs with
  | [] -> []
  | _ -> m @ srtInts << removeFst m xs 
