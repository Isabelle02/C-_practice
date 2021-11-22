using System;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            Team players = new Team();
            players[0] = new Player { Name = "Den", Num = 13 };
            players[10] = new Player { Name = "Sam", Num = 14 };

            Console.WriteLine(players[0]?.Name + " " + players[10]?.Num);
            Console.ReadKey();
        }
    }

    class Player
    {
        public string Name { get; set; }
        public int Num { get; set; }
    }

    class Team
    {
        Player[] players;

        public Team()
        {
            players = new Player[11];
        }

        public Player this[int index]
        {
            get
            {
                if (index >= 0 && index < players.Length)
                    return players[index];
                else return null;
            }
            set
            {
                if (index >= 0 && index < players.Length)
                    players[index] = value;
            }
        }
    }
}
