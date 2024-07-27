open System

printfn "Digite um numero: "
let num1 = int (Console.ReadLine())

printfn "Digite outro numero: "
let num2 = int (Console.ReadLine())

printfn "Digite outro numero: "
let num3 = int (Console.ReadLine())

let vrfTriangulo num1 num2 num3 =
    if (num1 + num2 > num3) && (num1 + num3 > num2) && (num2 + num3 > num1) then
        if num1 = num2 && num2 = num3 then
            sprintf "equilátero"
        elif num1 = num2 || num2 = num3 || num1 = num3 then
            sprintf "isósceles"
        else
            sprintf "escaleno"
    else
        sprintf "não é um triângulo"

let classificacao = vrfTriangulo num1 num2 num3

printfn "A classificação do triângulo é: %s" classificacao
