using System;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            int position = 0;
            Console.WriteLine("Position is " + position);

            Random random = new Random();
            int number = random.Next(0, 7);
            Console.WriteLine(number);

            int option = random.Next(0, 3);

            while (position <= 100)
            {
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        position = position + number;
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        position = position - number;
                        break;


                }
                if (position < 0)
                {
                    position = 0;
                }
            }
        }
    }
}




