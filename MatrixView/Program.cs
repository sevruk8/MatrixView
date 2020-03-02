using System;

namespace MatrixView
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Wake up text printing
            Console.WriteLine("Wake up, Neo...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\r\nThe Matrix has you...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\r\n\r\nFollow the White Rabbit.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\r\n\r\n\r\nKnock, knock, Neo.");
            Console.ReadKey();

            

            //Random number
            Random rand = new Random();

            //String pattern to screen
            String str = "";

            // Loop to display string pattern
            for (int i = 0; i < 20000; i++)
            {
                // create new string pattern
                if (i % 2 == 0)
                {
                    str = "";
                    for (int j = 0; j < 79; j++)
                    {
                        int n = rand.Next(5);
                        if (n < 2)
                        {
                            str += n.ToString();
                        }
                        else
                        {
                            str += " ";
                        }
                    }
                }
                // print str pattern
                Console.WriteLine(str);
            }

            // end of loop
            Console.WriteLine("End of screen...");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
