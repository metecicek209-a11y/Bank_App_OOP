
using myCSharpPractice;
using System.Collections.Specialized;

Customer Mete = new Customer("Mete Cicek",500, 12,"Flower");
Customer Bill = new Customer("Bill Clinton", 9999, 14,"Gun");
Customer Abraham = new Customer("Abrayham Lincoln",95000, 16,"Roses");

List<Customer> myDatabase = new List<Customer>();
myDatabase.Add(Mete);
myDatabase.Add(Bill);
myDatabase.Add(Abraham);
Console.WriteLine("Enter your id login ");
int login = Convert.ToInt32(Console.ReadLine());

foreach(Customer currentCustomer in myDatabase)
{
    if (login == currentCustomer.Password)
    {
        Console.WriteLine("Enter your username to login");
        string userName = Console.ReadLine();
        if (userName == currentCustomer.UserName) { 
            Console.WriteLine($"Hello Mr {currentCustomer.Name}");

            Console.WriteLine("To withdraw type 1");
            Console.WriteLine("To show balance type 2");
            Console.WriteLine("To exit press 9");

            int action = Convert.ToInt32(Console.ReadLine());
            while (action != 9)
            {

                if (action == 1)
                {
                    Console.Write("Enter an amount : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    currentCustomer.Withdraw(amount);
                    action = Convert.ToInt32(Console.ReadLine());
                }
                else if (action == 2)
                {
                    currentCustomer.ShowBalance();
                    action = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Type a defined number");
                    action = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Wrong username");
    }
    
}











