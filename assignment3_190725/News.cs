using System;
using System.Collections.Generic;

namespace assignment3_190725
{
    public class News : INews
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private float avgRate;

        private int[] rateList = new int[3];

        public News(int id, string title, string publishDate, string author, string content)
        {
            this.id = id;
            this.title = title;
            this.publishDate = publishDate;
            this.author = author;
            this.content = content;
        }

        public News()
        {
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string PublishDate
        {
            get => publishDate;
            set => publishDate = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public float AvgRate
        {
            get => avgRate;
            set => avgRate = value;
        }

        public void Display()
        {
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Title: " + this.Title);
            Console.WriteLine("Publish Date: " + this.PublishDate);
            Console.WriteLine("Author: " + this.Author);
            Console.WriteLine("Content: " + this.Content);
            Console.WriteLine("Average Rate: " + this.AvgRate);
        }

        public int this[int index]
        {
            get => rateList[index]; 
            set
            {
                if (value >= 1 && value <= 5)
                {
                    rateList[index] = value;
                }
                else if (value < 1)
                {
                    rateList[index] = 1;
                }
                else if (value > 5)
                {
                    rateList[index] = 5;
                }
            }
        }

        public void Calculate()
        {
            float sum = 0;
            foreach (int x in rateList)
            {
                sum += x;
            }

            avgRate = (float) sum / 3;
        }
    }
}