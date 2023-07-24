namespace filterNegative

module functions =
    let filterNegativeArray =
        fun (input: int array) ->
            let mutable output: int array = Array.empty

            for item: int in input do
                output <- if item > 0 then Array.append output [| item |] else output

            output

    let filterNegativeList =
        fun (input: int list) ->
            let mutable output: int list = List.Empty

            for item: int in input do
                output <- if item > 0 then List.append output [ item ] else output

            output
