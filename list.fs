module Lists

open System

type MyType = {N : int}
type MyList = int list

let max x y = if x < y then y else x

let maxList (x:int list) = List.reduce max x
