using System;
using System.Collections.Generic;

public class BowlingLane
{
    private List<Coordinate> pins;

    public BowlingLane()
    {
        ResetPins();
    }

    private void ResetPins()
    {
        pins = new List<Coordinate>
        {
            new Coordinate(0, 0), new Coordinate(0, 1), new Coordinate(0, 2), new Coordinate(0, 3),
            new Coordinate(1, 0), new Coordinate(1, 1), new Coordinate(1, 2),
            new Coordinate(2, 0), new Coordinate(2, 1),
            new Coordinate(3, 0)
        };
    }

    public void Print()
    {
        Console.Write("  ");
        for (int j = 0; j < 4; j++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" {j}");
            Console.ResetColor();
        }
        Console.WriteLine();

        for (int i = 0; i < 4; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{i} ");
            Console.ResetColor();

            for (int j = 0; j < 4; j++)
            {
                if (pins.Contains(new Coordinate(i, j)))
                    Console.Write(" X");
                else
                    Console.Write(" •");
            }
            Console.WriteLine();
        }
    }

    public int Throw(int x, int y)
    {
        Coordinate target = new Coordinate(x, y);
        int pinsKnocked = 0;

        if (pins.Remove(target))
        {
            pinsKnocked++;

            // Knock down adjacent pins with 50% chance
            Random rnd = new Random();
            List<Coordinate> adjacentPins = pins.FindAll(p => p.IsAdjacent(target));
            foreach (var pin in adjacentPins)
            {
                if (rnd.Next(2) == 0)
                {
                    pins.Remove(pin);
                    pinsKnocked++;
                }
            }
        }

        return pinsKnocked;
    }

    public bool AnyPinsStanding()
    {
        return pins.Count > 0;
    }
}

public struct Coordinate
{
    public int X { get; }
    public int Y { get; }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool IsAdjacent(Coordinate other)
    {
        return Math.Abs(X - other.X) <= 1 && Math.Abs(Y - other.Y) <= 1;
    }

    public override bool Equals(object obj)
    {
        return obj is Coordinate coordinate &&
               X == coordinate.X &&
               Y == coordinate.Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}
