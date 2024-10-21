//Run()
public class Program
{
    static void Main(string[] args)
    {
        // Kommentera ut eller ta bort denna rad
        // Game game = new Game();

        // Lägg till dessa rader istället
        BowlingLane lane = new BowlingLane();
        Console.WriteLine("Initial bowling lane state:");
        lane.Print();
    }
}
