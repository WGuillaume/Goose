namespace Consolegoose_game;

public class Player
{
    public Player(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public int Position { get; set; }

    public void DiceDraw6()
    {
        var dice = new Dice();
        var positioncase = dice.Throw();
        Console.WriteLine("le joueur " + Name + " a fait " + positioncase);
        Position += positioncase;
        Console.WriteLine("le joueur " + Name + " est sur la case " + Position);
    }

    public void DiceDraw9()
    {
        var dice = new Dice();
        var positioncase = dice.ThrowTwo();
        Console.WriteLine("le joueur " + Name + " a fait " + positioncase);
        Position += positioncase;
        Console.WriteLine("le joueur " + Name + " est sur la case " + Position);
    }

    public void PlayerPositionPiege()
    {
        var map = new Dictionary<int, int>
        {
            { 37, 12 },
            { 14, 7 },
            { 46, 33 },
            { 20, 35 },
            { 2, 17 },
            { 31, 43 },
            { 49, 1 }
        };
        if (map.ContainsKey(Position))
        {
            Position = map[Position];
            Console.WriteLine("le joueur " + Name + " est sur la case " + Position);
        }
    }
}