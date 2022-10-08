class Program {

    static void Main(string[] args) {
        DisplayWelcomeMessage();

        Deck deckOfCards = new Deck();
        Scoreboard score = new Scoreboard();
        string play = "";
        Card currentCard = null;
        Card newCard = null;
        int points = 0;

        do 
        {   
            if (play == "y")
            {
                currentCard = newCard;
                newCard = deckOfCards.DrawRandomCard();
            }
            else
            {
                currentCard = deckOfCards.DrawRandomCard();
                newCard = deckOfCards.DrawRandomCard();
            }
            Console.WriteLine("");
            Console.WriteLine($"The card is: {currentCard.Description()}");
            
            Console.Write("Higher or Lower [h/l]? ");
            string userGuess = Console.ReadLine() ?? "";
            
            Console.WriteLine($"Next card was: {newCard.Description()}");
            
            points = Convert.ToInt32(score.calculateNewScore(currentCard.number,newCard.number,userGuess));
            Console.WriteLine($"Your score is: {points}");
            
            if (score.checkScore(points) == true && deckOfCards.HasMoreCards())
            {
                Console.Write("Play again? [y/n] ");
                play = Console.ReadLine() ?? "";
            }
            else if (score.checkScore(points) == true && deckOfCards.HasMoreCards() == false)
            {
                Console.WriteLine("");
                Console.WriteLine($"You Won! There are no more cards in the deck! Your final score is {points}.");
                play = "n";
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"So close! Better luck next time. Your final score is {points}.");
                play = "n";
            }

        } while (deckOfCards.HasMoreCards() && play == "y");

        if (deckOfCards.HasMoreCards() && score.checkScore(points))
        {
            Console.WriteLine("");
            Console.WriteLine($"Game Over. Your final score is {points}.");
        }

        Console.WriteLine("Thank you for playing.");
        Console.WriteLine("");
    }

    static void DisplayWelcomeMessage() {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Welcome to the HiLo Game!");
        Console.WriteLine("");
    }
}
