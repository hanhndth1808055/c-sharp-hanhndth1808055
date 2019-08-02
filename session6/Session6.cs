using System;
using System.Threading;

namespace session6
{
    internal class Session6
    {
        public static void Main(string[] args)
        {
            Thread t = new Thread(delegate()
            {
                for (int i = 9; i >= 0; i--)
                {
                    for (int j = 59; j >= 0; j--)
                    {
                        Console.WriteLine(i.ToString("D2")+":"+j.ToString("D2"));
                        Thread.Sleep(1000);
                    }
                }
                Console.WriteLine("Boom...");
            }); 
            t.Start();
        }
    }
}