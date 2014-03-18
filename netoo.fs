type Human(nombre: string) =
   member x.Name = nombre
   abstract member Title: unit -> string
   default x.Title() = sprintf "human: %s" nombre

type CEO(name) =
   inherit Human(name)
   override x.Title() = sprintf "CEO: %s" name

let print_title (p : Human) = printfn "%s" (p.Title ())

print_title (Human("frew"))
print_title (CEO("frew"))
