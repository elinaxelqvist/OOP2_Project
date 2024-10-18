public class Left : IThrow
{
    string name;
    int power;

    public Left (string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    public void Choose()
    => Console.WriteLine($"{name} will be throwed with {power} % power!");
}