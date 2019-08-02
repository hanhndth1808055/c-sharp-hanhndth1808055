using System;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Text.RegularExpressions;

namespace assignment6_190802
{
    internal class Program

    {
        public static bool flag = false;
        public static int n;

        public static void Main(string[] args)
        {
            InsertNumber();

            Thread t2 = new Thread(delegate()
            {
                for (int i = 0; i <= 23; i++)
                {
                    for (int j = 0; j <= 59; j++)
                    {
                        Console.WriteLine(i.ToString("D2") + ":" + j.ToString("D2"));
                        Thread.Sleep(100);
                    }
                }
            });
            t2.Start();
            Thread t1 = new Thread(delegate()
            {
                int x = 1;
                int y = 1;
                int sum;
                while (!flag)
                {
                    {
                        sum = x + y;
                        x = y;
                        y = sum;
                        if (y >= n)
                        {
                            if (Math.Abs(x - n) < Math.Abs(y - n))
                            {
                                Thread.Sleep(100);
                                Console.WriteLine("The nearest Fibonacci number to 'n' is: " + x);
                                flag = true;
                                t2.Abort();
                            }
                            else if (Math.Abs(x - n) > Math.Abs(y - n))
                            {
                                Thread.Sleep(100);
                                Console.WriteLine("The nearest Fibonacci number to 'n' is: " + y);
                                flag = true;
                                t2.Abort();
                            }
                            else if (Math.Abs(x - n) == Math.Abs(y - n))
                            {
                                Thread.Sleep(100);
                                Console.WriteLine("The nearest Fibonacci numbers to 'n' are: " + x + ", " + y);
                                flag = true;
                                t2.Abort();
                            }
                        }
                    }
                }
            });
            t1.Start();
        }

        public static void InsertNumber()
        {
            Console.WriteLine("Please insert the number: ");
            n = Convert.ToInt16(Console.ReadLine());
        }
    }
}