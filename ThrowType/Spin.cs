public class Spin : IThrow
{
    string name;
    int power;

    public Spin (string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    public void Choose()
    => Consle.WriteLine($"{name} will be spinned with {power} % power!");
}