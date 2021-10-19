using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop
{
    class Program
    {
        static bool gameOver = (false);
        static int x;
        static int y;
        //if input is??????

        static void Main(string[] args)
        {
            while (gameOver == false)
            {
                ConsoleKeyInfo readKeyInput = Console.ReadKey(true); //ReadKey stored
                char input = readKeyInput.KeyChar; //extracting char

                if (input == 'w')
                {
                    y = y + 1;
                    Console.WriteLine(y);
                }
                if (input == 'a')
                {
                    x = x - 1;
                    Console.WriteLine(x);
                }
                if (input == 's')
                {
                    y = y - 1;
                    Console.WriteLine(y);
                }
                if (input == 'd')
                {
                    x = x + 1;
                    Console.WriteLine(x);
                }

            }
            if (gameOver == true)
            {
                Console.WriteLine("GAME OVER");
                Console.ReadKey(true);
            }
        }
    }
}
    

    

