public class dealer
{
    public int score = 300;

    public int calculateNewScore(previousCard,newCard,userGuess)
    {

        if (previousCard < newCard)
        {
            string correctGuess = "higher";
        }
        else
        {
            string correctGuess = "lower";
        }

        if (userGuess == correctGuess)
        {
            score += 100;
        }
        else if (userGuess != correctGuess)
        {
            score -= 75;
        }

        return score;
    }


}


class Deck
{
        //Create 52 cards:
        
        List<string> suits = new List<string> {"heart", "diamond", "spade", "club"};

        int cardCountPerSuit = 13;

        //Gets random cards from the deck 

}


public Deck() {
    BuildDeck();
}

void BuildDeck() {
    //If there are already cards in the deck, do not build them 
    if (Cards.Count != 0) {
        return;
    }

    //Creates 13 cards for each suit. 52 total cards 
    foreach (var suit in suits) {
        for (int i=1; i<=cardCountPerSuit; i++) {
            Card card = new card(suit, i);
            Cards.Add(card);
        }
    }
}


//below goes in Card.cs file
class Card 
{
    int number;
    string suit;

    public Card(int n, string s)
    {
        number = n;
        suit = s;
    }
}