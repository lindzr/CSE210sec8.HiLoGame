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
    //make a list of lists OR a dictionary with numbers 1-13 in each suit
    // "spades", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13
    //etc.
}

