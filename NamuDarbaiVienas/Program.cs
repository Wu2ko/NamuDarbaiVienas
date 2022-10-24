
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            ulong pirmas = 1;
            ulong antras = 1;
            ulong trecias;

           if (target > 92)
            { Console.Write("Too damn high!"); }

           else
            {
                if (target <= 3)
                {
                    Console.Write("Shame on you!");
                }
                else
                    for (int i = 0; i < target - 3; i++)
                    {
                        trecias = pirmas + antras;
                        pirmas = antras;
                        antras = trecias;

                        Console.Write(trecias);
                    }
            }  
            













            /////////////////////////////////////////////////////////// Zemiau rombas
            //Console.WriteLine("Number of lines: ");
            //int lines = int.Parse(Console.ReadLine());
            //int spaces = lines -1;
            //int stars = 1;
            //int spacesR = lines - spaces;// - 1;
            //int starsR = 1;


            //            for (int i = 0; i < lines; i++)
            //            {
            //                for (int y = 0; y < spaces; y++)
            //                {
            //                    Console.Write(" ");
            //                }
            //                for (int z = 0; z < stars; z++)
            //                {
            //                    Console.Write("* ");
            //                }

            //                spaces--;
            //                stars++;
            //                Console.WriteLine();
            //            }


            //////Reverse arrow

            //for (int i = 0; i < lines; i++)
            //{
            //    for (int a = spacesR; a > 0; a--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int b = lines; b > starsR; b--)
            //    {
            //        Console.Write("* ");
            //    }
            //    spacesR++;
            //    starsR++;

            //    Console.WriteLine();
            //}




        }
    }
}

