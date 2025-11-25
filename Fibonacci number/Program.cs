using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a = 0;
                int b = 1;
                int c;
                int counter = 1;

                Console.Write("How many Fibonacci numbers should I calculate? ");
                int x = int.Parse(Console.ReadLine());         
                Console.WriteLine("While loop:");
                while (counter <= x)
                {
                    Console.WriteLine(a);

                    c = a + b;
                    a = b;
                    b = c;
                    counter++;
                }


                Console.Write("How many Fibonacci numbers should I calculate? ");
                int x1 = int.Parse(Console.ReadLine());
                int a1 = 0;
                int b1 = 1;
                int c1;
                Console.WriteLine("For loop:");
                for (int i = 1; i <= x1; i++)
                {
                    Console.WriteLine(a1);
                    c1 = a1 + b1;
                    a1 = b1;
                    b1 = c1;

                }

                Console.WriteLine("\nPress enter to restart!!!");
                Console.ReadLine();
                Console.Clear();
            }

            
        }
    }
}
