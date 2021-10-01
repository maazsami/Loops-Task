using System;

namespace Final_Program_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Program" + "\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j= 1; j <=i; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine("\n");

            }


            Console.WriteLine( "2nd Program" + "\n");
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
           
                Console.WriteLine("\n");

            }

            


            Console.WriteLine("3rd Program" + "\n");

            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*" );
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine( "4th Program" + "\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("5th Program" + "\n");

            for (int i = 1; i <= 1; i++)
            {
                for (int j = 1; j <= 1; j++)
                {
                    Console.Write("*" + "\n");
                }
                Console.WriteLine("*");
            }
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 1; j <= 1; j++)
                {
                    Console.Write("*" + "\n");
                }
                Console.WriteLine("*");
            }

            Console.ReadKey();
        }
    }
}
