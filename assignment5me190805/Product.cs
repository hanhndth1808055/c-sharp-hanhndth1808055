using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace assignment5me190805
{
    public class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery;

        private event Notification ShowNotifyWhenChangePrice;
        private event Notification ShowNotifyWhenChangeQty;
        public Product(int id, string name, decimal price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = new List<string>();
        }

        public Product()
        {
            this.gallery = new List<string>();
        }

        public string this[int index]
        {
            get { return "link:" + Gallery[index]; }
            set
            {
                if (value.Length >10)
                {
                    Gallery[index] = value;
                }
            }
        }
        
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (ShowNotifyWhenChangePrice == null)
                {
                    ShowNotifyWhenChangePrice += Cart.ShowNotification;
                }

                if (this.Price != value && this.Price != 0)
                {
                    ShowNotifyWhenChangePrice("The price has been changed!");
                }
            }
        }

        public int Qty
        {
            get => qty;
            set
            {
                if (ShowNotifyWhenChangeQty == null)
                {
                    ShowNotifyWhenChangeQty += Cart.ShowNotification;
                }

                if (this.Qty != value && this.Qty != 0)
                {
                    ShowNotifyWhenChangeQty("The quantity has been changed!");
                }
            }
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> Gallery
        {
            get => gallery;
            set => gallery = value;
        }

        public virtual void TinhTien()
        {
            Product p = new Product();
            p.Gallery.Add("hellolink1");
            p.Gallery.Add("hellolink2");
         
            Console.WriteLine(p.Gallery[0]);
            Console.WriteLine(p[0]);
            p.Gallery[1] = "haha";
            p[1] = "abcxyz";
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + qty);
            Console.WriteLine("Image: " + image);
            Console.WriteLine("Description: " + desc);
            this.Image = "akefjkewf";
            foreach (string s in Gallery)
            {
                Console.WriteLine(s);
            }
        }

        public bool CheckQty()
        {
            if (qty > 0)
            {
                return true;
            }

            return false;
        }

        public bool AddGallery(string img)
        {
            if (Gallery.Count < 10)
            {
                Gallery.Add(img);
                return true;
            }
            Console.WriteLine("Excessing the number of images allowed.");
            return false;
        }

        public void AddGallery2()
        {
            if (Gallery.Count <10)
            {
                string img = Console.ReadLine();
                Gallery.Add(img);
                return;
            }
            Console.WriteLine("Excessing the number of images allowed.");
        }

        public void RemoveGallery()
        {
            int i = 0;
            foreach (string s in Gallery)
            {
                Console.WriteLine(i + ". " + s);
                i++;
            }
            
            Console.WriteLine("Insert the position of the picture to delete: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Gallery.RemoveAt(n);
            int j = 0;
            foreach (string s in Gallery)
            {
                Console.WriteLine(j + ". " + s);
                j++;
            }
        }

        public bool RemoveGallery(int n)
        {
            if (n < Gallery.Count)
            {
                Gallery.RemoveAt(n);
                return true;
            }
            Console.WriteLine("Cannot find the picture to delete.");
            return false;
        }
    }
}