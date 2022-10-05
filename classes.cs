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


public class deck
{
        //make a loop to create 52 cards
        List<card> deckofcards = new List<card>();

    enum number {
        1, 2, 3, 4, etc
    }

    enum suit {
        Hearts,
        Spades,
        Clubs,
        Diamonds,
    }
}


public class card 
{
    int number;
    string suit;

    public card(int n, string s)
    {
        number = n;
        suit = s;
    }
}