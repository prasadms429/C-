using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    enum Direction { North,South,East,West};
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Direction> directions = new List<Direction>();
            char input;

            do
            {
                Console.Write("Enter direction (n/s/e/w or '0' to exit): ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (input)
                {
                    case 'n':
                        directions.Add(Direction.North);
                        break;
                    case 's':
                        directions.Add(Direction.South);
                        break;
                    case 'e':
                        directions.Add(Direction.East);
                        break;
                    case 'w':
                        directions.Add(Direction.West);
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Enter valid input");
                        break;
                }
            } while (input != '0');

            Console.WriteLine($"You entered {directions.Count} directions. The directions are as follows:");

            foreach(Direction direction in directions)
            {
                Console.WriteLine(DirectionToSymbol(direction));
            }

            Console.ReadKey();
        }

        static string DirectionToSymbol(Direction direction)
        {
            switch(direction)
            {
                case Direction.North:
                    return "^";
                case Direction.South:
                    return "v";
                case Direction.East:
                    return ">";
                case Direction.West:
                    return "<";
                default:
                    return "";
            }
        }
    }
}
