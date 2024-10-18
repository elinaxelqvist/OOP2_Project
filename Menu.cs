//Knappval görs, tangenter
public class Menu
{
    public static Player GetMenu()
    {
        string playerName = ChoosePlayerName();

        Console.WriteLine(playerName);
        return new Player (playerName);

    }
    private static string ChoosePlayerName()
    {
        string playerName = "singlePlayer";
        return playerName;
    }
}