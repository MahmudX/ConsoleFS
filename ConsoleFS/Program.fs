open System

let Hello() =
    printf "Enter your name: "
    
    let name = Console.ReadLine()

    printfn "Hello %s" name

Hello()
Console.ReadKey() |> ignore