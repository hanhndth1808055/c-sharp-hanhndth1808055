namespace assignment4_190727
{
    public class PhoneItem
    {
        public string name;
        public string phone;

        public PhoneItem(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public PhoneItem()
        {
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Phone1
        {
            get => phone;
            set => phone = value;
        }

    }
}