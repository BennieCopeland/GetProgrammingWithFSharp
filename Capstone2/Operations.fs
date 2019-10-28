module Capstone2.Operations
    open Capstone2.Domain

    let deposit (amount: decimal) (account: Account) : Account =
        { account with Balance = account.Balance + amount }

    let withdraw amount account =
        if account.Balance >= amount then
            { account with Balance = account.Balance - amount }
        else
            account

    let auditAs operationName audit (operation: decimal -> Account -> Account) amount account =
        let newAccount = operation amount account
        let auditMessage =
            if newAccount.Balance = account.Balance then
                sprintf "Operation '%s' for $%.2f was rejected." operationName amount
            else
                sprintf "Performed operation '%s' for $%.2f. Balance is now $%.2f" operationName amount newAccount.Balance
                
        audit newAccount auditMessage
        newAccount