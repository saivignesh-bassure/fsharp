module IsbnVerifierTests

open FsUnit.Xunit
open Xunit

open IsbnVerifier

[<Fact>]
let ``Valid isbn`` () =
    isValid "3-598-21508-8" |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Invalid isbn check digit`` () =
    isValid "3-598-21508-9" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Valid isbn with a check digit of 10`` () =
    isValid "3-598-21507-X" |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Check digit is a character other than X`` () =
    isValid "3-598-21507-A" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Invalid check digit in isbn is not treated as zero`` () =
    isValid "4-598-21507-B" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Invalid character in isbn is not treated as zero`` () =
    isValid "3-598-P1581-X" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``X is only valid as a check digit`` () =
    isValid "3-598-2X507-9" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Valid isbn without separating dashes`` () =
    isValid "3598215088" |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Isbn without separating dashes and X as check digit`` () =
    isValid "359821507X" |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Isbn without check digit and dashes`` () =
    isValid "359821507" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Too long isbn and no dashes`` () =
    isValid "3598215078X" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Too short isbn`` () =
    isValid "00" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Isbn without check digit`` () =
    isValid "3-598-21507" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Check digit of X should not be used for 0`` () =
    isValid "3-598-21515-X" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Empty isbn`` () =
    isValid "" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Input is 9 characters`` () =
    isValid "134456729" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Invalid characters are not ignored after checking length`` () =
    isValid "3132P34035" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Invalid characters are not ignored before checking length`` () =
    isValid "3598P215088" |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
let ``Input is too long but contains a valid isbn`` () =
    isValid "98245726788" |> should equal false

