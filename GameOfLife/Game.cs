using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Game
    {

        public static int SizeX { get; set; }
        public static int SizeY { get; set; }
        public static bool[,] Grid { get; set; }

        public static void MakeRandomGrid(int x = 10, int y = 10)
        {
            SizeX = x;
            SizeY = y;
            bool[,] ngr = new bool[SizeX,SizeX];
            var rand = new Random();
            for (int ix = 0; ix < SizeX; ix++)
            {
                for (int iy = 0; iy < SizeY; iy++)
                {
                    bool a = rand.Next(0, 2) == 0;
                    ngr[ix, iy] = a;
                }
            }
            Grid = ngr;
        }

        public static void PaintGrid()
        {
            for (var ix = 0; ix < SizeX; ix++)
            {
                for (var iy = 0; iy < SizeY; iy++)
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
            catch (IndexOutOfRangeException ex)
            {
                //Console.WriteLine(ex);
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
            for (int ix = 0; ix < SizeX; ix++)
            {
                for (int iy = 0; iy < SizeY; iy++)
                {
                    Console.Write(GetNear(ix, iy));
                }
                Console.WriteLine("");
            }
        }

        public static void MakingLife()
        {
            for (int ix = 0; ix < SizeX; ix++)
            {
                for (int iy = 0; iy < SizeY; iy++)
                {
                    Grid[ix, iy] = Transform(GetNear(ix, iy), Grid[ix, iy]);
                }
            }
        }

    }
}