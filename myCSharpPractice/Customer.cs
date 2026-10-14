using System;
using System.Collections.Generic;
using System.Text;

namespace myCSharpPractice
{
    public class Customer
    {
        public string Name { get; set; }
        public string Sirname { get; set; }
        public int Balance { get; protected set; }  // protected ile miras alanlar da degistirebilir
        public string Username { get; }
        public string Password { get; }
        

        Customer(string name,string sirname,int balance,string username ,string password)
        {
            Name = name;
            Sirname = sirname;
            Balance = balance;
            Username = username;
            Password = password;
        }
        public void withdraw(int amount)
        {
            if(Balance >= amount && amount > 0)
            {
                Balance = Balance - amount;
            }
            
        }
        public void addMoney(int amount)
        {
            if (amount >= 0)
            {
                Balance = Balance + amount;
            }
            else
            {
                Console.WriteLine("amount is not right");
            }
        }
    }
}
