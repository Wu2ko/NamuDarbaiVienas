using System;

public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Number of linez: ");
            int lines = int.Parse(Console.ReadLine());
            int spaces = lines - 1;
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


        }
}
