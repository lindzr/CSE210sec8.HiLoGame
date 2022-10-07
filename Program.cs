class Program {

    static void Main(string[] args) {
        DisplayWelcomeMessage();

        // Create a new Deck object
        Deck deckOfCards = new Deck();

        // Loop continuously until the deck no longer has any cards
        do 
        {   
            Console.WriteLine($"The card is: {currentCard}");
            Console.WriteLine("Higher or Lower [h/l]? ");
            string userGuess = Console.ReadLine() ?? "";
            Console.WriteLine($"Next card was: {newCard}");
            Console.WriteLine($"Your score is: {score}");
            Console.WriteLine("Play again? [y/n] ");
            play = Console.ReadLine() ?? "";
            // Draw a random card from the deck
            Card newCard = deckOfCards.DrawRandomCard();
            
            // Print the card description to the console
            Console.WriteLine(newCard.Description());

        } while (deckOfCards.HasMoreCards());

        Console.WriteLine("");
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
