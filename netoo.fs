type Human(nombre: string) =
   member x.Name = nombre
   member x.Title() = sprintf "human: %s" nombre

type CEO(name) =
   inherit Human(name)
   member x.Title() = sprintf "CEO: %s" name

let print_title (p : Human) = printfn "%s" (p.Title ())

print_title (Human("frew"))
print_title (CEO("frew"))
