using System;
using GameOfLife;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 20;
            Game.MakeRandomGrid(x, y);
            Game.PaintGrid();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("--------------------------------------");
                Game.MakingLife();
                Game.PaintGrid();
            }
            Console.ReadKey();
        }
    }
}
