module Tests

open NUnit.Framework
open FsUnit

open Dojo

// From here you should write your tests

let [<Test>] ``This is a passing test`` () =
    isThisReallyTrue true |> shouldEqual true

let [<Test>] ``This is a failing test`` () =
    isThisReallyTrue false |> shouldEqual false
