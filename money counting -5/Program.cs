using System;

namespace quiz_ai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("games only 5$ cash");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
             {
              Console.WriteLine("Thats not all the money.");
            }
            else if (cash == 5)
             {
                Console.WriteLine("here are your games");
            }
            else
            {
            int change = cash - 5;
            Console.WriteLine("here are your games and " + change + " dallers in change left over");
            }

            // wait before closing
            Console.ReadKey();
        }
    }
}
