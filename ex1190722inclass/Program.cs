using System;
using System.Collections.Generic;

namespace ex1190722inclass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> intFibo = new List<int>();
            Console.WriteLine("Please insert the order number of the Fibonacci chain that you want to find: ");
            int x = Convert.ToInt32(Console.ReadLine());
            intFibo.Add(1);
            intFibo.Add(1);
            for (int i = 2; i < x; i++)
            {
                intFibo.Add(intFibo[i - 2] + intFibo[i - 1]);
            }

            Console.WriteLine(intFibo[x - 1]);
        }
    }
}
