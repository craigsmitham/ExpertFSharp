module Chapter2

let splitAtSpaces (text: string) =
    text.Split ' '
    |> Array.toList

let wordCount text =
    let words = splitAtSpaces text
    let wordSet = Set.ofList words
    let numWords = words.Length
    let numDups = words.Length - wordSet.Count
    (numWords, numDups)

let showWordCount text =
    let numWords, numDups = wordCount text
    printfn "--> %d words in the text" numWords
    printfn "--> %d duplicate words" numDups

let powerOfFour n =
    let nSquared = n * n 
    nSquared * nSquared