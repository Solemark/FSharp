//let num: float = 5
//printfn $"{num} + {num} = {calculator.addition num num}"
//printfn $"{num} - {num} = {calculator.subtraction num num}"
//printfn $"{num} * {num} = {calculator.multiplication num num}"
//printfn $"{num} / {num} = {calculator.division num num}"
//let input: string = "ABCDCBA"
//let inputB: string = "ABCDcBA"
//printfn $"{palindrome.functions.checkPalindrome input}"
//printfn $"{palindrome.functions.checkPalindrome inputB}"

let result: int array =
    filterNegative.functions.filterNegativeArray [| -5; -4; -3; -2; -1; 0; 1; 2; 3; 4; 5 |]

printfn "Filter from array: "

for item in result do
    printf $"{item},"

let resultB: int list =
    filterNegative.functions.filterNegativeList [ -5; -4; -3; -2; -1; 0; 1; 2; 3; 4; 5 ]

printfn "Filter from list: "

for item in resultB do
    printf $"{item},"
