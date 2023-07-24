namespace fizzBuzz

module functions =
    let fizzbuzz =
        fun (fizz: int) (buzz: int) (max: int) ->
            let mutable output: string = ""
            let mutable flag: bool = false

            for i = 1 to max do
                flag <- false

                if 0 = i % fizz then
                    flag <- true
                    output <- $"{output}fizz"

                if 0 = i % buzz then
                    flag <- true
                    output <- $"{output}buzz"

                if flag = false then
                    output <- $"{output}{i}"

                if i <> max then
                    output <- $"{output}, "

            output
