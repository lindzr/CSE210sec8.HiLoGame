// create scoreboard to keep track of user points during game
public class Scoreboard
{
    public int score = 300;
// sets rules for whether guess is correct or incorrect. Assigns points values to guess and returns new score
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
// checks if score has hit or gone below 0 to end or continue game
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
