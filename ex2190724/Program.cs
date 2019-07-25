namespace ex2190724
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cart cart = new Cart(1, "Nguyen Doan Hanh", "Hanoi", "Vietnam");
            cart.addProduct();
            cart.addProduct();
            cart.addProduct();
            cart.removeProduct();
            cart.calculateGrandTotal();
//            Product p = new Product(1, "Oppo mobile", 60, 2, "Imagelink1", "Description mobile.");
//            p.addPicture();
//            p.addPicture();
//            p.addPicture();
//            p.addPicture();
//            p.addPicture();
//            p.addPicture();
//            p.addPicture();
//            p.addPicture();
//            p.addPicture();
//            p.addPicture();
//            p.addPicture();
//            p.getInfo();
//            Product p1 = new Product(1, "Samsung mobile", 80, 0, "Imagelink2", "Description mobile 2.");
//            p.stockStatus();
//            p1.stockStatus();
//            p.removePicture();
        }
    }
}