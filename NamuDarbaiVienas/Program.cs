﻿
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of lines: ");
            int lines = int.Parse(Console.ReadLine());
            int spaces = lines;// - 1;
            int stars = 1;


            for (int i = 0; i < lines; i++)
            {
                for (int y = 0; y < spaces; y++)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z < stars; z++)
                {
                    Console.Write("* ");
                }

                spaces--;
                stars++;
                Console.WriteLine();
            }

            for (int i = 0; i < lines; i++)
            {
                for (int a = spaces; a > 0; a--)
                {
                    Console.Write(" ");
                }
                for (int b = lines; b > stars; b--)
                {
                    Console.Write("* ");
                }
                spaces++;
                stars++;

                Console.WriteLine();
            }




        }
    }
}

