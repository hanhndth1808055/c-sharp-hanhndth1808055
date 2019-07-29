using System;

namespace assignment4_190727
{
    public abstract class Phone
    {
        public abstract void insertPhone(string name, string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newPhone);
        public abstract void searchPhone(string name);

    }
}