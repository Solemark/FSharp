namespace diceRoll

open System

module functions =
    let roll = fun (max: int) -> Random.Shared.Next(max) + 1
