
type Card = { Numero: string; Palo: string }

type Cards(jokerExists: bool) =
    let palos = [ "♠️"; "♣️"; "♥️"; "️️♦️" ]
    let numeros = [ "As"; "2"; "3"; "4"; "5"; "6"; "7"; "Jack"; "Queen"; "King" ]
    let existsJ = jokerExists


    member this.deck =
        Seq.zip (Seq.ofList palos) (Seq.ofList numeros)
        |> List.ofSeq
        |> List.map (fun (x, y) -> { Palo = x; Numero = y })


let rnd = new System.Random()

type Game() =
    let Cards = new Cards(false)
    let mutable deck = Cards.deck
    let mutable discard = []
    member this.Deck = deck
    member this.Discard: List<Card> = discard

    member this.Draw() =
        let h = this.Deck[0]
        let newDiscard = this.Discard @ [ h ]
        let newDeck = List.tail this.Deck
        discard <- newDiscard
        deck <- newDeck
        h

    member this.Shuffle(list: List<'a>) =
        let mutable newList = Array.ofList (list)

        for _ in 1 .. (list.Length - 1) do
            let k = rnd.Next(list.Length - 1)
            let temp = newList[k]
            newList[k] <- newList[newList.Length - 1]
            newList[list.Length - 1] <- temp

        deck <- newList |> List.ofArray
        newList |> List.ofArray

    static member Start() =
        let GameInstance = Game()
        GameInstance.Shuffle(GameInstance.Deck)
        let drawnCard = GameInstance.Draw()
        printfn "%A" drawnCard


let game = Game()
Game.Start()