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
            Game.PaintGrid();
            Console.WriteLine("--------------------------------------");
            Game.CheckLife();
            Console.WriteLine("--------------------------------------");
            Game.PaintGrid();
            Game.MakingLife();
            Console.WriteLine("--------------------------------------");
            Game.PaintGrid();

            Console.ReadKey();
        }
    }
}
