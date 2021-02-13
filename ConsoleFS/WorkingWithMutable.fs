module WorkingWithMutable
open System

let bind() = 
    let mutable weight = 175
    weight <- 170
    printfn "Weight: %i" weight

    let change_me = ref 10
    change_me := 20
    printfn "Change: %i" ! change_me