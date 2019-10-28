namespace Capstone2.Domain
open System

type Customer = {
    Name : string
}

type Account = {
    AccountId : Guid
    Balance : decimal
    Owner : Customer
}