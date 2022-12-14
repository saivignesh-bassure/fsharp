module SayTests

open FsUnit.Xunit
open Xunit

open Say

[<Fact>]
let ``Zero`` () =
    say 0L |> should equal (Some "zero")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``One`` () =
    say 1L |> should equal (Some "one")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Fourteen`` () =
    say 14L |> should equal (Some "fourteen")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Twenty`` () =
    say 20L |> should equal (Some "twenty")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Twenty-two`` () =
    say 22L |> should equal (Some "twenty-two")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Thirty`` () =
    say 30L |> should equal (Some "thirty")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Ninety-nine`` () =
    say 99L |> should equal (Some "ninety-nine")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``One hundred`` () =
    say 100L |> should equal (Some "one hundred")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``One hundred twenty-three`` () =
    say 123L |> should equal (Some "one hundred twenty-three")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Two hundred`` () =
    say 200L |> should equal (Some "two hundred")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Nine hundred ninety-nine`` () =
    say 999L |> should equal (Some "nine hundred ninety-nine")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``One thousand`` () =
    say 1000L |> should equal (Some "one thousand")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``One thousand two hundred thirty-four`` () =
    say 1234L |> should equal (Some "one thousand two hundred thirty-four")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``One million`` () =
    say 1000000L |> should equal (Some "one million")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``One million two thousand three hundred forty-five`` () =
    say 1002345L |> should equal (Some "one million two thousand three hundred forty-five")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``One billion`` () =
    say 1000000000L |> should equal (Some "one billion")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``A big number`` () =
    say 987654321123L |> should equal (Some "nine hundred eighty-seven billion six hundred fifty-four million three hundred twenty-one thousand one hundred twenty-three")

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Numbers below zero are out of range`` () =
    say -1L |> should equal None

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Numbers above 999,999,999,999 are out of range`` () =
    say 1000000000000L |> should equal None

