public class Player
{
    // Fält för att lagra spelarens namn och poäng
    public string Name { get; private set; }
    public int Score { get; private set; }

    // Konstruktor för att skapa en spelare med ett namn
    public Player()
    {
        Console.WriteLine("What's your name?");
        Name = Console.ReadLine();
        Score = 0; // Startar med 0 poäng
        Console.WriteLine("Hello " + Name + "! Choose your game mode:");
    }
}