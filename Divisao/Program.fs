open System

printfn "Digite um número: "
let num1 = int (Console.ReadLine())

printfn "Digite outro número: "
let num2 = int (Console.ReadLine())

let dividir num1 num2 =
    if num1 > num2 then
        num1 / num2
    else
        num2 / num1

let result = dividir num1 num2

printfn "O resultado da divisão é: %d" result
