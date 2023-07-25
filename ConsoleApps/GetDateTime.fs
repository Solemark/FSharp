namespace getDateTime

open System

module functions =
    let getDay =
        fun (day: int) ->
            match day with
            | 1 -> $"{day}st"
            | 2 -> $"{day}nd"
            | 3 -> $"{day}rd"
            | 21 -> $"{day}st"
            | 22 -> $"{day}nd"
            | 23 -> $"{day}rd"
            | 31 -> $"{day}st"
            | _ -> $"{day}th"

    let getMonth =
        fun (month: int) ->
            match month with
            | 1 -> "January"
            | 2 -> "February"
            | 3 -> "March"
            | 4 -> "April"
            | 5 -> "May"
            | 6 -> "June"
            | 7 -> "July"
            | 8 -> "August"
            | 9 -> "September"
            | 10 -> "October"
            | 11 -> "November"
            | 12 -> "December"
            | _ -> "invalid month"

    let checkDate =
        let date: DateTime = DateTime.Now

        let result: string =
            $"It is {date.DayOfWeek} the {getDay date.Day} of {getMonth date.Month}, {date.Year}"

        result
