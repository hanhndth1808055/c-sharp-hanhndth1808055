using System;
using assignment5_190802.T1809E_CSharp;

namespace assignment5_190802
{
    public class Shoes : Product,IProduct
    {
        public void KiemTraGiaTien()
        {
            int i = 2;
        }
                
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Day la san pham giay dep");
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