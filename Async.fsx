let root =
    async{
        do printfn "Root"
    }|>Async.Start

let x =
    async{
        root
        do printfn "\nx"
    }|>Async.Start

let y =
    async{
        x
        do printfn "\ny"
    }|>Async.Start

let z =
    async{
        y
        do printfn "\nz"
    }|>Async.Start

let head =
    async{
        z
        do printfn "\nhead"
    }|>Async.Start

head
