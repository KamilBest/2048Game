using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Game
    {
        public Game()
        {
        }

        public void play()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            switch (cki.Key)
            {
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
            }
        }
    }
}