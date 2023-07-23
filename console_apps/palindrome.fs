module palindrome

let get_char = fun (input: char[]) (key: int) -> input[key]

let check_palindrome =
    fun (input: string) ->
        let data: char[] = input.ToCharArray()
        let mutable i: int = 0
        let mutable c: int = data.Length - 1
        let mutable result: bool = true
        let mutable flag: bool = false

        while flag = false do
            result <- if get_char data i <> get_char data c then false else true

            if result = false then
                flag <- true
            elif i = c then
                flag <- true

            i <- i + 1
            c <- c - 1

        result
