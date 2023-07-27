namespace ConsoleApps.SourceCode.Palindrome

module functions =
    let getChar = fun (input: char[]) (key: int) -> input[key]

    let checkPalindrome =
        fun (input: string) ->
            let data: char[] = input.ToCharArray()
            let mutable i: int = 0
            let mutable c: int = data.Length - 1
            let mutable result: bool = true
            let mutable flag: bool = false

            while flag = false do
                result <- if getChar data i <> getChar data c then false else true

                if result = false || i = c then
                    flag <- true

                i <- i + 1
                c <- c - 1

            result
