// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
let suma a b = a + b
let resta a b = a - b
let mult a b = a * b
let div a b = a / b

let main =
    let a = 10
    let b = 4
    let n = suma a b
    printfn "Valor suma: %i" n

    let n = resta a b
    printfn "Valor resta: %i" n

    let n = mult a b
    printfn "Valor multiplicasion: %i" n

    let n = div a b
    printfn "Valor division: %i" n

do main