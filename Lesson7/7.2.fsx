open System
let describeAge age =
    let ageDescription =
        if age < 18 then "Child!"
        elif age < 65 then "Adule!"
        else "OAP!"
    
    let greeting = "Hello"
    Console.WriteLine("{0}! You are a '{1}'.", greeting, ageDescription)
    
let u = ()
let r = describeAge 38
u = r