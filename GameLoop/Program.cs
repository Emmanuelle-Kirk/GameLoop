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
                    Console.WriteLine("UP");
                }
                if (input == 'a')
                {
                    Console.WriteLine("LEFT");
                }
                if (input == 's')
                {
                    Console.WriteLine("DOWN");
                }
                if (input == 'd')
                {
                    Console.WriteLine("RIGHT");
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
    

    

