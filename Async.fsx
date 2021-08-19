let work =
    async{
        do! Async.Sleep 2000
        do printfn "First"
    }

work
|> Async.Start

printfn "Second"

work
|> Async.RunSynchronously

printfn "Second"

let task =
    async{
        let name = "james"
        return name
    } |> Async.StartAsTask

let value = task.Result

printfn "%s" value