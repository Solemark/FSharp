namespace ConsoleApps.Unittest

open System
open ConsoleApps.SourceCode.Calculator
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass() =

    [<TestMethod>]
    member this.TestMethodPassing() = Assert.IsTrue(true)
