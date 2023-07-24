namespace convertDistance

module functions =
    let convert =
        fun (distance: float, key: string) ->
            if key = "ktm" then
                distance * (float 0.0213712)
            else
                distance * (float 1.609344)
