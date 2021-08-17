type User = User of System.Guid
 
type Post = {
    Content : string
    NumberOfViews : int
}

let user username : User option =
    System.Guid.NewGuid()
    |> User
    |> Some


let PostsOfUser (user:User option) : Post list =
    match user with
    | Some user ->
        [
            {NumberOfViews = 10; Content = "conten5"}
            {NumberOfViews = 11; Content = "content4"}
            {NumberOfViews = 102; Content = "content3"}
            {NumberOfViews = 132; Content = "content1"}
            {NumberOfViews = 123; Content = "content2"}
        ]
    | None -> []

let top3 posts =
    posts
    |> List.sortByDescending(fun post -> post.NumberOfViews)
    |> List.take 3

let contents posts =
   posts
   |> List.map(fun post -> post.Content)

user "james"
|> PostsOfUser
|> top3
|> contents