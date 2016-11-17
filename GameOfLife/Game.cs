using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Game
    {
        public static void Hi()
        {
            Console.WriteLine("Grid");
        }

        public static bool[,] Grid { get; set; }

        public static void MakeRandomGrid(int x = 10, int y = 10)
        {
            bool[,] ngr = new bool[x,y];
            var rand = new Random();
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    bool a = rand.Next(0, 2) == 0;
                    ngr[ix, iy] = a;
                }
            }
            Grid = ngr;
        }

        private static bool MakeRandomValue()
        {
            return new Random().Next(0, 2) == 0;
        }
    }
}
