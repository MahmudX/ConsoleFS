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

    [10; 20; 5; 6; 7]
    |> List.filter (fun v -> (v % 2) = 0)
    |> List.map (fun x -> x * 2)
    |> printfn "Even number doubled : %A"

let WeirdFunc() =
    let mult_num x = x * 3
    let add_num y = y + 5

    let mult_add = mult_num >> add_num
    let add_mult = mult_num << add_num

    printfn "mult_add \t: %i" (mult_add 10)
    printfn "add_mult \t: %i" (add_mult 10)
    printfn "mult_num \t: %i" (mult_num 10)
    printfn "add_num  \t: %i" (add_num 10)