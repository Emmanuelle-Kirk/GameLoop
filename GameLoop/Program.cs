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

        static void PlayerDraw()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(".");
        }
        static void PlayerUpdate()
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true); //ReadKey stored
            char input = readKeyInput.KeyChar; //extracting char
            if (input == 'w')
            {
                y = y - 1;
                //Console.WriteLine("y = " + y);
            }
            if (input == 'a')
            {
                x = x - 1;
                //Console.WriteLine("x = " + x);
            }
            if (input == 's')
            {
                y = y + 1;
                //Console.WriteLine("y = " + y);
            }
            if (input == 'd')
            {
                x = x + 1;
                //Console.WriteLine("X = " + x);
            }
            if (x <= -1)
            {
                x = x + 1;
            }
            if (y <= -1)
            {
                y = y + 1;
            }
            if (x >= 117)
            {
                x = x - 1;
            }
           if (y >= 29)
            {
                y = y - 1;
            }
        }
        static void Main(string[] args)
        {
            while (gameOver == false)
            {
                PlayerUpdate();
                PlayerDraw();
            }
            Console.WriteLine("GAME OVER");
            Console.ReadKey(true);
        }
    }
}
    

    

