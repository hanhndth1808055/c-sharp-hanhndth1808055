using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace assignment4_190727
{
    public class PhoneBook : Phone
    {
        public List<PhoneItem> Phonelist = new List<PhoneItem>();
        
       public override void insertPhone(string name, string phone)
       {
           bool flag = false;
            foreach (PhoneItem p in Phonelist)
            {
                if (p.Name == name && p.Phone1 == phone)
                {
                    flag = true;
                    break;
                }
                if (p.Name == name && p.Phone1 != phone)
                {
                    flag = true;
                    p.Phone1 += " : " + phone;
                    break;
                }
            }

            if (!flag)
            {
                PhoneItem np = new PhoneItem(name, phone);
                Phonelist.Add(np);
            }
            showPhonelist();
        }

       public override void removePhone(string name)
       {
           for (int i = 0; i < Phonelist.Count; i++)
           {
               if (Phonelist[i].Name == name)
               {
                   Phonelist.Remove(Phonelist[i]);
               }
           }
          
           showPhonelist();
       }

       public override void updatePhone(string name, string newPhone)
       {
           foreach (PhoneItem p in Phonelist)
           {
               if (p.Name == name)
               {
                   p.Phone1 = newPhone;
               }
           }
           showPhonelist();
       }

       public override void searchPhone(string name)
       {
           foreach (PhoneItem p in Phonelist)
           {
               if (p.Name == name)
               {
                   Console.WriteLine("Customer " + p.Name + " has the phone number " + p.Phone1);
               }
           }
       }

       public void showPhonelist()
       {
           foreach (PhoneItem p in Phonelist)
           {
               Console.WriteLine("Customer: " + p.Name + " - Phone number: " + p.Phone1);
           }
       }
    }
}