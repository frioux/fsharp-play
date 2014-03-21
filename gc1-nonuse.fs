type DisposableHuman (name : string) =
  do printfn "Creating person: %s" name
  member x.Name = name
  interface System.IDisposable with
    member x.Dispose() =
      printfn "disposing: %s" name

let testDisposable() =
  let root = new DisposableHuman("outer")
  for i in [1..2] do
    let nested = new DisposableHuman(sprintf "inner %i" i)
    printfn "completing iteration %i" i
  printfn "leaving function"

testDisposable ()
