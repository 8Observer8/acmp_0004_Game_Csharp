using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acmp_0004_Game_Csharp;

namespace UsageGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Game g = new Game();
            int result = g.game(number);
            System.Console.WriteLine(result.ToString());
        }
    }
}
