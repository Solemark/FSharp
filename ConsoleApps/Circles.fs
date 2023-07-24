namespace Circles

open System

module functions =
    let getCircumference =
        fun (radius: float) ->
            if radius <= (float 0) then
                (float 0)
            else
                (float 2) * Math.PI * radius

    let getArea =
        fun (radius: float) ->
            if radius <= (float 0) then
                (float 0)
            else
                Math.PI * (radius * radius)
