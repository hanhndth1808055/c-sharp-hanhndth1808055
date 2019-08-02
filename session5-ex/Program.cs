using System;

namespace session5_ex
{
    public delegate void showString(string s);

    public class Program
    {
        public static void Main(string[] args)
        {
            showString s1 = new showString(SayHello);
            showString s2 = new showString(new Program().StartDinner);
            showString s3 = new showString(Running);
//
//            s1 += s2;
//            s1 += s3;
//            s1("Happy this!");
            string abc = "string abcddflwjef";
            showString s4 = delegate(string s)
            {
                s = "hello " + s + abc; 
                Console.WriteLine(s);
            };

            s4("Nguyen Van Nam");
        }

        public static void SayHello(string str)
        {
            Console.WriteLine("Say: " + str);
        }

        public void StartDinner(string ss)
        {
            Console.WriteLine("Say Dinner: " + ss);
        }

        public static void Running(string s)
        {
            Console.WriteLine("Run: " + s);
        }
    }
}