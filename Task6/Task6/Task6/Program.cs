using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                Level = 2,
                Point = 100
            };
            Player player2 = new Player
            {
                Level = 4,
                Point = 50
            };

            List<Player> players = new List<Player> { player1, player2 };
        }

        static IEnumerable<Player> Sort(List<Player> players, string property)
        {
            switch (property.ToUpper())
            {
                case "POINT":
                    return players.OrderBy(p => p.Point);
                case "LEVEL":
                    return players.OrderBy(p => p.Level);
                default:
                    return null;
            }

        }
    }
    public class Player
    {
        public int Point { get; set; }
        public int Level { get; set; }
    }
}
