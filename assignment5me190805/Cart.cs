using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace assignment5me190805
{
    public delegate void Notification(string s);

    public class Cart
    {
        public int id;
        public string customer;
        public decimal grandTotal;
        public List<Product> productList;
        public string city;
        public string country;

        public event Notification NotifyWhenAddProduct;

        public Cart(int id, string customer, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.city = city;
            this.country = country;
            this.productList = new List<Product>();
        }

        public Cart()
        {
            this.productList = new List<Product>();
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public decimal GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public List<Product> ProductList
        {
            get => productList;
            set => productList = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public static void ShowNotification(string s)
        {
            Console.WriteLine(s);
        }

        public bool AddProduct(Product p)
        {
            if (!productList.Contains(p) && p.CheckQty())
            {
                productList.Add(p);
                p.qty--;
                grandTotal += p.price;
                if (NotifyWhenAddProduct == null)
                {
                    NotifyWhenAddProduct += ShowNotification;
                }

                NotifyWhenAddProduct("The product has been added to the cart.");
                return true;
            }

            Console.WriteLine("The item is in the cart.");
            return false;
        }

        public bool RemoveProduct(Product p)
        {
            if (productList.Contains(p))
            {
                productList.Remove(p);
                p.qty++;
                grandTotal -= p.price;
                return true;
            }

            Console.WriteLine("The item is not in the cart.");
            return false;
        }

        public decimal GetGrandTotal()
        {
            decimal finalTotal;
            if (country == "VN")
            {
                if (city == "HN" || city == "HCM")
                {
                    finalTotal = grandTotal * (decimal) 1.01;
                }
                else
                {
                    finalTotal = grandTotal * (decimal) 1.02;
                }
            }
            else
            {
                finalTotal = grandTotal * (decimal) 1.05;
            }

            return finalTotal;
        }

        public void ShowCart()
        {
            Console.WriteLine("------CART------");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Customer name: " + Customer);
            Console.WriteLine("City: " + City);
            Console.WriteLine("Country: " + Country);
            Console.WriteLine("Grand total: " + GetGrandTotal());
            Console.WriteLine("Product list: ");
            foreach (Product p in productList)
            {
                Console.WriteLine(p.Id + " - " + p.Name + " - " + p.Price + " - " + p.Qty + " - " + p.Image + " - " +
                                  p.Desc);
                Console.WriteLine("Gallery list of this product: ");
                foreach (string s in p.Gallery)
                {
                    Console.WriteLine(s);
                }
            }

            Console.WriteLine("---------------------------------------");
        }
    }
}