type DisposableHuman (name : string) =
  do printfn "Creating person: %s" name
  member x.Name = name
  interface System.IDisposable with
    member x.Dispose() =
      printfn "disposing: %s" name

let testDisposable() =
  use root = new DisposableHuman("outer")
  for i in [1..2] do
    let name = using (new DisposableHuman(sprintf "inner %i" i)) (fun disp -> disp.Name)
    printfn "got name %s" name
  printfn "leaving function"

testDisposable ()

