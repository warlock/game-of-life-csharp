using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;
            Game.Hi();
            Game.MakeRandomGrid(x, y);
            for (var ix = 0; ix < x; ix++)
            {
                for (var iy = 0; iy < y; iy++)
                {
                    Console.Write(Game.Grid[ix, iy]?"X":"O");
                }
                Console.Write("\n");
            }
            Console.WriteLine(Game.GetNear(2,2));

            Console.ReadKey();
        }
    }
}
