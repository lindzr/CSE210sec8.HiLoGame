public class dealer
{
    public int score = 300;

    public int calculateNewScore(previousCard,newCard,userGuess)
    {
        string guess = userGuess;
        if (previousCard < newCard)
        {
            score =+ 100;
        }
        else
        {
            score -= 75;
        }
        return score;
    }

    public 
}