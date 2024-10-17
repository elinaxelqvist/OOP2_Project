public class Right : IThrow
{
    string name;
    int power;

    public Right (string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    public void Choose()
    => Consle.WriteLine($"{name} will be throwed with {power} % power!");
}