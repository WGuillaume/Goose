namespace Consolegoose_game;

public class Dice
{
    //proprietes
    private readonly Random random = new();


    //methode
    public int Throw()
    {
        return random.Next(1, 6);
    }

    public int ThrowTwo()
    {
        return random.Next(2, 9);
    }
}