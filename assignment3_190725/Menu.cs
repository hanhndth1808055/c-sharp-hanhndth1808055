using System;
using System.Collections.Generic;

namespace assignment3_190725
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            bool start = true;
            List<News> list = new List<News>();
            while (start)
            {
                ShowMenu();
                int menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        InsertNews(list);
                        break;
                    case 2:
                        ListNews(list);
                        break;
                    case 3:
                        AvgRate(list);
                        break;
                    case 4:
                        start = false;
                        break;
                }
            }
        }

        static void AvgRate(List<News> list)
        {
            foreach (News news in list)
            {
                news.Calculate();
                news.Display();
            }
        }

        static void InsertNews(List<News> list)
        {
            Console.WriteLine("Input ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Input date: ");
            string pdate = Console.ReadLine();
            Console.WriteLine("Input author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Input content: ");
            string content = Console.ReadLine();
            News ns = new News(id, title, pdate, author, content);
            Console.WriteLine("Input 3 values of rate: ");
            for (int i = 0; i < 3; i++)
            {
                ns[i] = Convert.ToInt16(Console.ReadLine());
            }
            list.Add(ns);
        }

        static void ListNews(List<News> list)
        {
            foreach (News news in list)
            {
                news.Display();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Please choose the function");
            Console.WriteLine("1. Insert news");
            Console.WriteLine("2. View news list");
            Console.WriteLine("3. Average rate");
            Console.WriteLine("4. Exit");
        }
    }
}