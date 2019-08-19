using System;

namespace assignment5me190805
{
    public class Shoes : Product, IProduct
    {
        public Shoes(int id, string name, decimal price, int qty, string image, string desc) : base(id, name, price, qty, image, desc)
        {
        }

        public Shoes()
        {
        }

        public void KiemTraGiaTien()
        {
            int i = 2;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("This is shoe product.");
        }

        public override void TinhTien()
        {
        }

        public new bool CheckQty()
        {
            if (qty > 1)
            {
                return true;
            }

            return false;
        }
    }
}