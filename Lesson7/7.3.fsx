open System

let now = System.DateTime.UtcNow.TimeOfDay.TotalHours
if now < 12.0 then Console.WriteLine "It's morning"
elif now < 18.0 then Console.WriteLine "It's afternoon"
elif now < 20.0 then ignore(5 + 5)
else ()