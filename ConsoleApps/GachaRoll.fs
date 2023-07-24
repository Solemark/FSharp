namespace gachaRoll

open System

module functions =
    let roll =
        fun (game: string) ->
            let mutable rolls: int = 0
            let mutable currentRoll: int = 0
            let mutable rate: int = 0
            let mutable pity: int = 0
            let mutable rarity: string = ""
            let mutable output: string = ""
            let mutable flag: bool = true

            match game with
            | "FGO" ->
                rate <- 100
                pity <- 100
                rarity <- "5*"
            | "AK" ->
                rate <- 50
                pity <- 100
                rarity <- "6*"
            | "GI" ->
                rate <- 60
                pity <- 90
                rarity <- "5*"
            | _ ->
                flag <- false
                output <- "unknown game!"

            while flag = true do
                rolls <- rolls + 1
                currentRoll <- Random.Shared.Next(rate + 1)

                if currentRoll = rate then
                    flag <- false
                    output <- $"It took {rolls} rolls to get a {rarity} in {game}"

                if rolls = pity then
                    flag <- false
                    output <- $"You hit pity at {pity} rolls for your {rarity} in {game}"

            output
