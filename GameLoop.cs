using System;
namespace Consolegoose_game
{
	public class GameLoop
	{
        //protrietes
        public List<Player> Players { get; }
        public bool IsGameFinished { get; set; }


        //constructeur
        public GameLoop(List<Player> players)
        {
            Players = players;
            IsGameFinished = false;
        }

        //methode
        //lancement game(boucle game)
        public void StartGame()
        {   
            int turnCount = 1;
            
            Console.WriteLine("Nous sommes au tour " + turnCount);
            while (!IsGameFinished)
            {
                foreach(var player in Players)
                {


                    if (turnCount == 5)
                    {
                        player.DiceDraw9();
                        turnCount++;

                    }
                    else 
                    { 
                        player.DiceDraw6();
                        turnCount++;
                    }
                    Console.ReadLine();
                    
                    Console.WriteLine("Nous sommes au tour " + turnCount);
                    
                    if (player.Position == 50)
                    {
                        IsGameFinished = true;
                        Console.WriteLine("Finish!! Is Winner player " + player.Name + " 🎉.");
                    }
                    



                    player.PlayerPositionPiege();



                }
            }
        }

        public static void Initialization()
        {
            var players = AskAllPlayerInformation();
            var gameLoop = new GameLoop(players);
            gameLoop.StartGame();
        }
        
        public static List<Player> AskAllPlayerInformation()
        {
            var players = new List<Player>();
            var playerCount = AskPlayerNumber();
            for (int i = 0; i < playerCount; i++)
            {
                players.Add(AskOnePlayerInformation(i));
            }
            return players;
        }
        public static Player AskOnePlayerInformation(int numberPlayer)
        {
            Console.WriteLine("Entrer le nom du joueur");
            var playername = Convert.ToString(Console.ReadLine());
            return new Player(playername);
        }
        public static int AskPlayerNumber()
        {
            Console.WriteLine("Bienvenue dans le goose game!!!!\nCombien de joueur ete vous ?");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

