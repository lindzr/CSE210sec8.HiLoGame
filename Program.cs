class Program {

    static void Main(string[] args) {
        DisplayWelcomeMessage();

        Deck deckOfCards = new Deck();
        Score score = new Score();
        string play = "";

        do 
        {   
            if (play == "y")
            {
                currentCard = newCard;
                newCard = deckOfCards.DrawRandomCard();
            }
            else
            {
                Card currentCard = deckOfCards.DrawRandomCard();
                Card newCard = deckOfCards.DrawRandomCard();
            }
            
            Console.WriteLine($"The card is: {currentCard.Description()}");
            
            Console.WriteLine("Higher or Lower [h/l]? ");
            string userGuess = Console.ReadLine() ?? "";
            
            Console.WriteLine($"Next card was: {newCard.Description()}");
            
            Console.WriteLine($"Your score is: {score.calculateNewScore(currentCard.number(),newCard.number(),userGuess)}");
            
            Console.WriteLine("Play again? [y/n] ");
            play = Console.ReadLine() ?? "";

        } while (deckOfCards.HasMoreCards() && play == "y");

        Console.WriteLine("");
        Console.WriteLine("Thank you for playing.");
    }

    static void DisplayWelcomeMessage() {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Welcome to the HiLo Game!");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }
}
