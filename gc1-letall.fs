type DisposableHuman (name : string) =
  do printfn "Creating person: %s" name
  member x.Name = name
  member x.Teardown() =
    printfn "disposing: %s" name
  interface System.IDisposable with
    member x.Dispose() = x.Teardown ()

let testDisposable() =
  let root = new DisposableHuman("outer")
  for i in [1..2] do
    let nested = new DisposableHuman(sprintf "inner %i" i)
    printfn "completing iteration %i" i
    nested.Teardown ()
  printfn "leaving function"
  root.Teardown ()

testDisposable ()
