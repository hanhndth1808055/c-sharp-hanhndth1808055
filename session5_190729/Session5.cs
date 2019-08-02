using System;

namespace session5_190729
{    
    public delegate void showString(string s);
    public class Session5
    {
        public static void Main(string[] args)
        {
            showString s1 = new showString(SayHello);
            // s1("Happy birthday!");
            showString s2 = new showString(new Session5().StartDinner);
            //  s2("Happy birthday!");
            showString s3 = new showString(Running);
//          s1 += s2;
//          s1 += s3;
           
            s1 += s2 += s3;
            // s2 = s2 + s3;
            // s1 = s1 + s2;
          
            // s1 = s1 + s2 + s3;
            // s2 = s2 + s3;
            s1("Happy birthday!");
            
            string abc = "afafafa";
            showString s4 = delegate(string s)
            {
                s = "hello " + s + abc;
                Console.WriteLine(s);
            };

            s4("Nguyen van Nam");
          
            PhoneBook pb = new PhoneBook();
            pb.InsertPhone("Vu", "0987654321");
            Console.WriteLine("---------");
            pb.UpdatePhone("Vu", "0123456789");
        }

        public static void SayHello(string str)
        {
            Console.WriteLine("Say "+str);
        }

        public void StartDinner(string ss)
        {
            Console.WriteLine("Start Dinner "+ss);
        }

        public static void Running(string s)
        {
            Console.WriteLine("Run: "+s);
        }
    }
}