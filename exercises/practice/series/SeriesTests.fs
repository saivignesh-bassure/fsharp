module SeriesTests

open FsUnit.Xunit
open Xunit

open Series

[<Fact>]
let ``Slices of one from one`` () =
    slices "1" 1 |> should equal (Some ["1"])

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Slices of one from two`` () =
    slices "12" 1 |> should equal (Some ["1"; "2"])

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Slices of two`` () =
    slices "35" 2 |> should equal (Some ["35"])

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Slices of two overlap`` () =
    slices "9142" 2 |> should equal (Some ["91"; "14"; "42"])

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Slices can include duplicates`` () =
    slices "777777" 3 |> should equal (Some ["777"; "777"; "777"; "777"])

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Slices of a long series`` () =
    slices "918493904243" 5 |> should equal (Some ["91849"; "18493"; "84939"; "49390"; "93904"; "39042"; "90424"; "04243"])

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Slice length is too large`` () =
    slices "12345" 6 |> should equal None

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Slice length is way too large`` () =
    slices "12345" 42 |> should equal None

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Slice length cannot be zero`` () =
    slices "12345" 0 |> should equal None

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Slice length cannot be negative`` () =
    slices "123" -1 |> should equal None

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Empty series is invalid`` () =
    slices "" 1 |> should equal None

