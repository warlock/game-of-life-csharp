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

        public static int GetNear(int x, int y)
        {
            int n = 0;
            if (Grid[x - 1, y - 1]) n++;
            if (Grid[x - 1, y]) n++;
            if (Grid[x - 1, y + 1]) n++;
            if (Grid[x, y-1]) n++;
            if (Grid[x, y + 1]) n++;
            if (Grid[x + 1, y - 1]) n++;
            if (Grid[x + 1, y]) n++;
            if (Grid[x + 1, y + 1]) n++;
            return n;
        }

        public static int CheckRes(int x, int y)
        {
            return GetNear(x, y);
        }

        private static bool Check(int x, int y)
        {
            return Grid[x, y];
        }

        public static bool Transform(int near, bool actual)
        {
            if (near == 0 && actual) return true;
            else if (near == 3 && actual) return true;
            else if (near > 3 && actual) return false;
            else return false;
        }

        public static void Life(int x = 10, int y = 10)
        {
        }

    }
}
