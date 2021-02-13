module DoSum


let Sum(x : int, y : int) : int = 
    let z = x + y
    z

let Do_Func() = 

    let rec factorial x =
        if x < 1 then 1
        else x * factorial (x - 1)

    printfn "Factorial 4 : %i" (factorial 4)

let Work_List() = 
    let rand_list = [5;6;2]
    
    let rand_list_two = List.map(fun x -> x*2) rand_list

    printfn "Double List : %A" rand_list_two