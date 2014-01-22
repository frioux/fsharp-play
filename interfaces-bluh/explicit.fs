type IHasName =
   abstract member Name : unit -> string

type IHasNickName =
   abstract member Name : unit -> string

type Human(nombre) =
   interface IHasName with
      member x.Name() = nombre
   interface IHasNickName with
      member x.Name() = nombre + "y"

printfn "name %s" ((Human("frew") :> IHasName).Name ())
printfn "nickname %s" ((Human("frew") :> IHasNickName).Name ())

