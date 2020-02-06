open System
module PigLatin =
    let toPigLatin (word : string) = 
        let isVowel (c : char) = 
            match c with 
            | 'a' | 'e' | 'i' | 'o' | 'u'
            | 'A' | 'E' | 'I' | 'O' | 'U' -> true
            | _ -> false

        if isVowel word.[0] then 
            word + "yay"
        else word.[1..] + string(word.[0]) + "ay"

[<EntryPoint>]
let main _ =
    printfn "Type a word to see it translated into Pig Latin"
    let name = Console.ReadLine()
    let newName = PigLatin.toPigLatin name
    printfn "%s in Pig Latin is: %s" name (newName.ToLowerInvariant())
    0 // return an integer exit code
