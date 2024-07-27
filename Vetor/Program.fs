open System

let vetor = [0..20]

printfn "Vetor original:"
vetor |> List.iter (printf "%d ")

printfn "\n"

let processarNumeros vetor =
    vetor
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map (fun x -> x * 2)
    |> List.filter (fun x -> x % 6 = 0)

printfn "Vetor filtrado:"
let vetorFiltrado = processarNumeros vetor

vetorFiltrado |> List.iter (printf "%d ")