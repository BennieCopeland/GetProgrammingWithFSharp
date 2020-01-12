module Tests

open FsCheck
open FsCheck.Xunit
open System

let flipCase (text: string) =
    text.ToCharArray()
    |> Array.map(fun c ->
        if Char.IsUpper c then Char.ToLower c
        else Char.ToUpper c)
    |> String

type LettersOnlyGen() =
    static member Letters() =
        Arb.Default.Char() |> Arb.filter Char.IsLetter

    
[<Property(Arbitrary = [|typeof<LettersOnlyGen>|], Verbose = true)>]
let ``Always has same number of letters`` (NonEmptyString input) =
    let output = input |> flipCase
    input.Length = output.Length
