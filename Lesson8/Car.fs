module Car

open System

//TODO: Create helper functions to provide the building blocks to implement driveTo.

let getDistance (destination) =
    if destination = "Gas" then 10
    elif destination = "Home" then 25
    elif destination = "Stadium" then 25
    elif destination = "Office" then 50
    else failwith "Unknown destination!"
    
let calculateRemainingPetrol(currentPetrol, distance) =
    if currentPetrol > distance then currentPetrol - distance
    else failwith "Oops! You've run out of petrol!"

/// Drives to a given destination given a starting amount of petrol
let driveTo (petrol, destination) =
    let distance = getDistance destination
    let remainingPetrol = calculateRemainingPetrol (petrol, distance)
    if destination = "Gas" then remainingPetrol + 50
    else remainingPetrol