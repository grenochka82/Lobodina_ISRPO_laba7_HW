using System;

class Dice
{
    private int _sides;
    private Random random;
    public Dice(int sides = 6)
    {
        this._sides = sides;
        this.random = new Random();
    }
    public int Roll()
    {
        return random.Next(1, _sides + 1);
    }
}

class Program
{
    static void Main()
    {
        Dice dice6 = new Dice(); 
        Dice dice12 = new Dice(12); 

        Console.Write("6-гранный кубик: ");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(dice6.Roll() + " ");
        }

        Console.WriteLine();

        Console.Write("12-гранный кубик: ");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(dice12.Roll() + " ");
        }
        Console.WriteLine();
    }
}