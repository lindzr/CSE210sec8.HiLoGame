int currentCard = 0;
int newCard = 0;
int score = 300;
string play = "";

do
{
    Console.WriteLine($"The card is: {currentCard}");
    Console.WriteLine("Higher or Lower [h/l]? ");
    string userGuess = Console.ReadLine();
    Console.WriteLine($"Next card was: {newCard}");
    Console.WriteLine($"Your score is: {score}");
    Console.WriteLine("Play again? [y/n] ");
    play = Console.ReadLine();
}while (play == "y");

Console.WriteLine("Thanks for playing!");