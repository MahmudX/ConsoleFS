open System
open WorkingWithMutable
open DoSum
open ClassLibrary
//open ContosoCpp


let Hello() =
    printf "Enter your name: "
    
    let name = Console.ReadLine()

    printfn "Hello %s" name

    printfn "PI : %f" 3.141592

let Pi() = 
    let big_pi = 3.1415926535897932384626433832M
    printfn "PI : %M" big_pi

let DynamicPadding() =
    printfn "%5s %5s" "a" "b"
    printfn "%*s" 12 "Hi"

//DynamicPadding()

//Do_Func()

//printfn "Sum is : %i" (Sum(5,6))

//Work_List()

WeirdFunc()

Partner.PrintPartner("Mahmud")
//Contoso.DoSomething()

Console.ReadKey() |> ignore