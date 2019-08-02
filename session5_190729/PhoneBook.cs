using System;
using System.Collections.Generic;

namespace session5_190729
{
    public delegate void ChangeValue(string s);
    
    public class PhoneBook : Phone
    {
        public event ChangeValue PhoneChange;
        
        public List<PhoneNumber> PhoneList;
        
        public override bool InsertPhone(string name, string phone)
        {
            if (PhoneList == null)
            {
                PhoneList = new List<PhoneNumber>();
            }
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    if (!p.Phone.Equals(phone))
                    {
                        p.Phone += ":" + phone;
                        return true;
                    }

                    return false;
                }
            }
            PhoneList.Add(new PhoneNumber(name,phone));
            return true;
        }

        public override bool RemovePhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    PhoneList.Remove(p);
                    return true;
                }
            }

            return false;
        }

        public override bool UpdatePhone(string name, string newphone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    p.Phone = newphone;
                    if (PhoneChange == null)
                    {
                        PhoneChange += Notify;
                    }
                    PhoneChange("So dien thoai cua "+ name +" da bi thay doi");
                    return true;
                }
            }

            return false;
        }

        public static void Notify(string s)
        {
            Console.WriteLine(s);
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }

            return null;
        }
    }
}