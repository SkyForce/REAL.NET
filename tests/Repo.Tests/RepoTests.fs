﻿module RepoTests

open NUnit.Framework
open FsUnit

open Repo

let mutable private repo = RepoFactory.CreateRepo () :?> RepoImpl

[<SetUp>]
let setup () =
    repo <- RepoFactory.CreateRepo () :?> RepoImpl

[<Test>]
let ``Repo shall be able to load a model`` () =
    let modelLoader = GraphMetametamodel () :> IModelLoader
    modelLoader.LoadInto repo

[<Test>]
let ``Repo shall return some metamodel nodes`` () =
    (repo :> IRepo).MetamodelNodes () |> should not' (be Empty)

[<Test>]
let ``Repo shall return some model nodes`` () =
    (repo :> IRepo).ModelNodes () |> should not' (be Empty)

[<Test>]
let ``Repo shall contain at least ModelElement`` () =
    (repo :> IRepo).ModelNodes () |> Seq.filter (fun x -> x.name = "ModelElement") |> should not' (be Empty)
