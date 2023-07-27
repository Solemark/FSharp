namespace test

open System
open ConsoleApps.Unittest
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass() =

    [<TestMethod>]
    member this.TestMethodPassing() = Assert.IsTrue(true)

    [<TestMethod>]
    member this.TestAddition() =
        let expect: float = (float 10)
        let result: float = functions.addition (float 5) (float 5)
        Assert.AreEqual(expect, 2)
