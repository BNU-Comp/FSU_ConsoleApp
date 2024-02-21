open System

// Exercise 1
(*
let name = "Kate Ibom"
let age = 21
let height = 1.8
printfn "%s" name
printfn "%i" age
printfn "%f" height

// Exercise 2
System.Console.WriteLine(name)
System.Console.WriteLine(age)
System.Console.WriteLine(height)
*)

// Exercise 3
(*
printfn "Enter your name"
let name = Console.ReadLine()

printfn "Enter your age"
let age = int(Console.ReadLine())

Console.Write("Enter your height in meters > ")
let height = float(Console.ReadLine())

Console.WriteLine($"Your name = {name}")
Console.WriteLine($"Your age is {age} years")
Console.WriteLine($"Your height is {height} meters")
*)

// ChatGPT Function to get user input as an integer

let rec getInteger (message: string) (minValue: int) (maxValue: int) : int =
    Console.Write(message)
    let mutable userInput = 0

    try
        userInput <- Int32.Parse(Console.ReadLine())
        if userInput < minValue || userInput > maxValue then
            printfn "Error: The number must be between %d and %d" minValue maxValue
            getInteger message minValue maxValue
        else
            userInput
    with
    | :? FormatException ->
        printfn "Error: Invalid input. Please enter a valid integer."
        getInteger message minValue maxValue
    | :? OverflowException ->
        printfn "Error: The number you entered is too large or too small."
        getInteger message minValue maxValue

[<EntryPoint>]
let main argv =
    let minValue = 1
    let maxValue = 100
    let userInput = getInteger "Please enter an integer between 1 and 100 > " minValue maxValue
    printfn "You entered: %d" userInput

    0 // Exit code


