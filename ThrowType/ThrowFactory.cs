using System.Collections.Generic;

public class ThrowFactory : IThrow
{
    private List<IThrow> throws;

    public ThrowFactory()
    {
        throws = new List<IThrow>
        {
            new Left("Left", 50),
            new Right("Right", 60),
            new Spin("Spin", 70)
        };
    }

    public void Choose()
    {
        // Implementera logik för att välja ett kast
    }
    
    // Andra metoder...
}
