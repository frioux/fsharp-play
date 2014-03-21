let createDisposable name =
  printfn "creating: %s" name
  { new System.IDisposable with
    member x.Dispose() =
      printfn "disposing: %s" name
  }

let testDisposable() =
  let root = createDisposable "outer"
  for i in [1..2] do
    let nested = createDisposable (sprintf "inner %i" i)
    printfn "completing iteration %i" i
    nested.Dispose ()
  root.Dispose ()
  printfn "leaving function"

testDisposable ()
