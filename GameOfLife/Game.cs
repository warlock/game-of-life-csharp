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

        public static void PaintGrid(int x = 10, int y = 10)
        {
            for (var ix = 0; ix < x; ix++)
            {
                for (var iy = 0; iy < y; iy++)
                {
                    Console.Write(Grid[ix, iy] ? "X" : "O");
                }
                Console.WriteLine("");
            }
        }

        public static int GetNear(int x, int y)
        {
            int n = 0;

                if (CheckRes(x - 1, y - 1)) n++;
                if (CheckRes(x - 1, y)) n++;
                if (CheckRes(x - 1, y + 1)) n++;
                if (CheckRes(x, y - 1)) n++;
                if (CheckRes(x, y + 1)) n++;
                if (CheckRes(x + 1, y - 1)) n++;
                if (CheckRes(x + 1, y)) n++;
                if (CheckRes(x + 1, y + 1)) n++;
            
            return n;
        }

        public static bool CheckRes(int x, int y)
        {
            try
            {
                return Grid[x, y];
            }
            catch (IndexOutOfRangeException ex)
            {
                //Console.WriteLine(ex);
                return false;
            }
        }

        private static bool GetVal(int x, int y)
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

        public static void CheckLife(int x = 10, int y = 10)
        {
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < x; iy++)
                {
                    Console.Write(GetNear(ix, iy));
                }
                Console.WriteLine("");
            }
        }

        public static void MakingLife(int x = 10, int y = 10)
        {
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < x; iy++)
                {
                    Grid[ix, iy] = Transform(GetNear(ix, iy), Grid[ix, iy]);
                }
            }
        }

    }
}
