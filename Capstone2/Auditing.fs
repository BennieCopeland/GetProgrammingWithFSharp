module Capstone2.Auditing
    open System
    open System.IO
    open Capstone2.Domain
    
    let fileSystemAudit account message =
        let path = sprintf @"C:\tmp\learnfs\capstone2\%s" account.Owner.Name
        let fileName = sprintf "%O.txt" account.AccountId
        Directory.CreateDirectory path |> ignore
        let file = Path.Combine( path, fileName)
        File.AppendAllText( file, sprintf "%s%s" message Environment.NewLine )

    let consoleAudit account message =
        let accountId = account.AccountId.ToString()
        Console.WriteLine(printfn "Account %s: %s" accountId message)