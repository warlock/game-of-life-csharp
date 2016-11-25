using System;

namespace GameOfLife
{
    public class Game
    {

        public static bool[,] Grid { get; set; }

        public static void MakeRandomGrid(int x = 10, int y = 10)
        {
            Grid = new bool[x,y];
            var rand = new Random();
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    bool a = rand.Next(0, 2) == 0;
                    Grid[ix, iy] = a;
                }
            }
        }

        public static void PaintGrid()
        {
            for (var ix = 0; ix < Grid.GetLength(0); ix++)
            {
                for (var iy = 0; iy < Grid.GetLength(1); iy++)
                {
                    Console.Write(Grid[ix, iy] ? "X" : "O");
                }
                Console.WriteLine("");
            }
        }

        public static int GetNear(int x, int y)
        {
            int n = 0;
            if (GetVal(x - 1, y - 1)) n++;
            if (GetVal(x - 1, y)) n++;
            if (GetVal(x - 1, y + 1)) n++;
            if (GetVal(x, y - 1)) n++;
            if (GetVal(x, y + 1)) n++;
            if (GetVal(x + 1, y - 1)) n++;
            if (GetVal(x + 1, y)) n++;
            if (GetVal(x + 1, y + 1)) n++;
            return n;
        }

        public static bool GetVal(int x, int y)
        {
            try
            {
                return Grid[x, y];
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        public static bool Transform(int near, bool actual)
        {
            if (near == 0 && actual) return true;
            else if (near == 3 && actual) return true;
            else if (near > 3 && actual) return false;
            else return false;
        }

        public static void CheckLife()
        {
            for (int ix = 0; ix < Grid.GetLength(0); ix++)
            {
                for (int iy = 0; iy < Grid.GetLength(1); iy++)
                {
                    Console.Write(GetNear(ix, iy));
                }
                Console.WriteLine("");
            }
        }

        public static void MakingLife()
        {
            for (int ix = 0; ix < Grid.GetLength(0); ix++)
            {
                for (int iy = 0; iy < Grid.GetLength(1); iy++)
                {
                    Grid[ix, iy] = Transform(GetNear(ix, iy), Grid[ix, iy]);
                }
            }
        }


    }
}