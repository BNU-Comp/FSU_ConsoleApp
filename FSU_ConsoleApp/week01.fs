﻿module Week01

open System

    // Exercise 01

module exercise01 = 
    
    let run () = 
        let name = "Kate Ibom"
        let age = 21
        let height = 1.8
    
        printfn "%s" name
        printfn "%i" age
        printfn "%f" height

// Exercise 3

module exercise03 =

    let run () =
        printfn "Enter your name"
        let name = Console.ReadLine()

        let age = Helpers.getInteger "Enter your age > " 0 120

        Console.Write("Enter your height in meters > ")
        let height = float(Console.ReadLine())

        Console.WriteLine($"Your name = {name}")
        Console.WriteLine($"Your age is {age} years")
        Console.WriteLine($"Your height is {height} meters")

