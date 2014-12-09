using System;

namespace GenericMethods
{
    public interface IAccount
    {
        decimal Balance { get; }
        string Name { get; }
    }


    public class Account : IAccount
    {
        public string Name { get; private set; }
        public decimal Balance { get; private set; }

        public Account(string name, Decimal balance)
        {
            Name = name;
            Balance = balance;
        }
    }

}
