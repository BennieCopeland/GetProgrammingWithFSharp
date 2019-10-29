#load "Domain.fs"
#load "Operations.fs"

open Capstone3.Operations
open Capstone3.Domain
open System


let isValidCommand command =
    let validCommands = [ 'd'; 'w'; 'x' ]
    List.contains command validCommands

let isStopCommand command =
    if command = 'x' then true
    else false

let getAmount command =
    if command = 'd' then ('d', 50M)
    elif command = 'w' then ('w', 25M)
    else ('x', 0M)

let processCommand account (command, amount) =
    if command = 'w' then withdraw amount account
    elif command = 'd' then deposit amount account
    else account


let openingAccount = { Owner = { Name = "Isaac" }; Balance = 0M; AccountId = Guid.Empty }

let account =
    let commands = [ 'd'; 'w'; 'z'; 'f'; 'd'; 'x'; 'w' ]
    
    commands
    |> Seq.filter isValidCommand
    |> Seq.takeWhile (not << isStopCommand)
    |> Seq.map getAmount
    |> Seq.fold processCommand openingAccount