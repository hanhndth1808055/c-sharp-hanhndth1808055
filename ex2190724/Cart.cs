using System;
using System.Collections.Generic;

namespace ex2190724
{
    public class Cart
    {
        public int id;
        public string customer;
        public double grandTotal;
        public List<Product> productList = new List<Product>();
        public string city;
        public string country;

        public Cart(int id, string customer, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.city = city;
            this.country = country;
        }

        public Cart()
        {
        }

        public void addProduct()
        {
            Console.WriteLine("Please insert product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert product name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please insert product price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please insert the quantity of the product: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert image link: ");
            string image = Console.ReadLine();
            Console.WriteLine("Please insert description: ");
            string desc = Console.ReadLine();
            Product p = new Product(id, name, price, qty, image, desc);
            Console.WriteLine("Please insert the number of pictures you want to add to this product: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                p.addPicture();
            }

            productList.Add(p);
        }

        public void removeProduct()
        {
            Console.WriteLine("Please insert the product id to remove: ");
            int x = Convert.ToInt32(Console.ReadLine());
            productList.RemoveAt(x - 1);
        }

        public void calculateGrandTotal()
        {
            grandTotal = 0;
            for (int i = 0; i < productList.Count; i++)
            {
                grandTotal += productList[i].price * productList[i].qty;
            }

            if (country != "Vietnam")
            {
                grandTotal = grandTotal * 1.05;
            }
            else if (country == "Vietnam" && (city == "Hanoi" || city == "HoChiMinh"))
            {
                grandTotal = grandTotal * 1.01;
            }
            else
            {
                grandTotal = grandTotal * 1.02;
            }

            Console.WriteLine("Grand total: " + grandTotal);
        }
    }
}