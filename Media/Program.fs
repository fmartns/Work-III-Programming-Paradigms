open System

let registrarNotas () = 
    printfn "Digite a primeira nota: "
    let nota1 = float (Console.ReadLine())

    printfn "Digite a segunda nota: "
    let nota2 = float (Console.ReadLine())

    printfn "Digite a terceira nota: "
    let nota3 = float (Console.ReadLine())

    (nota1 + nota2 + nota3 ) / 3.0

let verificarMedia media =
    media >= 6.0

let verificarAprovacao aprovado =
    if aprovado then
        printfn "Aprovado"
    else
        printfn "Reprovado"

let resultadoNotas () =
    registrarNotas ()
    |> verificarMedia
    |> verificarAprovacao
    
resultadoNotas ()
