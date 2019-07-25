using System;
using System.Collections.Generic;

namespace ex2190724
{
    public class Product
    {
        public int id;
        public string name;
        public double price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery = new List<string>();

        public Product(int id, string name, double price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public Product()
        {
        }

        public void getInfo()
        {
            Console.WriteLine("ID: " + id + " - Name: " + name + " - Price: " + price +
                              " - Quantity: " + qty + " - Image: " + image + " - Description: " + desc);
            for (int i = 0; i < gallery.Count; i++)
            {
                Console.WriteLine("Image " + (i + 1) + ": " + gallery[i]);
            }
        }

        public Boolean stockStatus()
        {
            if (qty > 0)
            {
                Console.WriteLine("In Stock");
                return true;
            }

            Console.WriteLine("Out of Stock");
            return false;
        }

        public void removePicture()
        {
            Console.WriteLine("Current pictures: ");
            for (int i = 0; i < gallery.Count; i++)
            {
                Console.WriteLine("Image " + (i + 1) + ": " + gallery[i]);
            }

            Console.WriteLine("=========================");
            Console.WriteLine("Please select the order of picture to delete: ");
            int x = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(x - 1);
        }

        public void addPicture()
        {
            int count = gallery.Count;
            if (count < 10)
            {
                Console.WriteLine("Please insert image link: ");
                string str = Console.ReadLine();
                gallery.Add(str);
            }
            else if (count == 10)
            {
                Console.WriteLine(
                    "Cannot add more. Please select if you want to delete a picture to add more: 1. Yes 2. No");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    removePicture();
                    Console.WriteLine("Please insert image link: ");
                    string str = Console.ReadLine();
                    gallery.Add(str);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You keep the current gallery.");
                }
            }
        }
    }
}