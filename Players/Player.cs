public class Player
{
    public string name { get; private set; }

    public Player(string playerName)
    {
        this.name = playerName;
    }

    // // Fält för att lagra spelarens namn och poäng

    // public int Score { get; private set; }

    // // Konstruktor för att skapa en spelare med ett namn
    // public Player()
    // {
    //     Console.WriteLine("What's your name?");
    //     Name = Console.ReadLine();
    //     Console.WriteLine("Hello " + Name + "! Choose your game mode:");
    // }
}