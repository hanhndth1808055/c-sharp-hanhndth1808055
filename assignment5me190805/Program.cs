using System;

namespace assignment5me190805
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cart cart = new Cart(1, "Tran Van A", "HN", "VN");
            Product coat = new Product(1, "Coat", 400, 2, "https://abc.com/abc.jpg",
                "The trending coat in the summer collection of VH fashion brand.");
            coat.AddGallery("https:abc.com/pic1.jpg");
            coat.AddGallery("https:abc.com/pic2.jpg");
            coat.AddGallery("https:abc.com/pic3.jpg");
            coat.AddGallery("https:abc.com/pic4.jpg");
            coat.AddGallery("https:abc.com/pic5.jpg");
            coat.AddGallery("https:abc.com/pic6.jpg");
            coat.AddGallery("https:abc.com/pic7.jpg");
            coat.AddGallery("https:abc.com/pic8.jpg");
            coat.AddGallery("https:abc.com/pic9.jpg");
            coat.AddGallery("https:abc.com/pic10.jpg");
            coat.AddGallery("https:abc.com/pic11.jpg");
            coat.RemoveGallery();

            Shoes shoes = new Shoes(1, "Vans Shoes", 200, 1, "https://abc.com/abcd.jpg", "The new teen shoes.");
            shoes.AddGallery("https:abc.com/pic1.jpg");
            cart.AddProduct(coat);
            cart.AddProduct(shoes);
            cart.ShowCart();
            Console.WriteLine(cart.GetGrandTotal());
            cart.RemoveProduct(shoes);
            cart.ShowCart();
            Console.WriteLine(cart.GetGrandTotal());
        }
    }
}