using System;

namespace assignment4_190727
{
    internal class Program
    {
        public static PhoneBook phoneBook = new PhoneBook();

        public static void Main(string[] args)
        {
            bool start = true;

            while (start)
            {
                showMenu();
                int menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        insertPhone();
                        break;
                    case 2:
                        removePhone();
                        break;
                    case 3:
                        updatePhone();
                        break;
                    case 4:
                        searchPhone();
                        break;
                    case 5:
                        start = false;
                        break;
                }
            }
        }

        public static void showMenu()
        {
            Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM");
            Console.WriteLine("1. Insert Phone");
            Console.WriteLine("2. Remove Phone");
            Console.WriteLine("3. Update Phone");
            Console.WriteLine("4. Search Phone");
            Console.WriteLine("5. Exit");
        }

        public static void insertPhone()
        {
            Console.WriteLine("Please insert name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please insert phone number: ");
            string phone = Console.ReadLine();
            phoneBook.insertPhone(name, phone);
        }

        public static void removePhone()
        {
            Console.WriteLine("Please insert name: ");
            string name = Console.ReadLine();
            phoneBook.removePhone(name);
        }

        public static void updatePhone()
        {
            Console.WriteLine("Please insert name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please insert new phone number: ");
            string newphone = Console.ReadLine();
            phoneBook.updatePhone(name, newphone);
        }

        public static void searchPhone()
        {
            Console.WriteLine("Please insert name: ");
            string name = Console.ReadLine();
            phoneBook.searchPhone(name);
        }
    }
}