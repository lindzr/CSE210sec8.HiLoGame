public class Scoreboard
{
    public int score = 300;

    public int calculateNewScore(int previousCard, int newCard, string userGuess)
    {

        string correctGuess = "";

        if (previousCard < newCard)
        {
            correctGuess = "h";
        }
        else
        {
            correctGuess = "l";
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

    public bool checkScore(int score)
    {
        if (score > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
