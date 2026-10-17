
using myCSharpPractice;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
Customer Mete = CustomerCreator("Mete", "Cicek", 100000, "mete", "cicek112");
List<Customer> myDatabase = new List<Customer>();
myDatabase.Add(Mete);
LoginMenu();
// musteri donduren bir fonksiyon yaz
Customer InfoChecker(string username, string password)
{
    foreach(Customer selectedCustomer in myDatabase)
    {
        if(selectedCustomer.Username == username)
        {
            if(selectedCustomer.Password == password)
            {
                return selectedCustomer;
            }
            else
            {
                Console.WriteLine("Your password is wrong");
            }
        }
        else
        {
            Console.WriteLine("Your username is wrong");
        }
    }
    return null;
}
void LoginMenu()
{
    Console.WriteLine("-----------------------");
    while (true)
    {
        Console.WriteLine("Welcome to Cicek Bank");
        Console.WriteLine("To continiou please enter your username");
        string typeUsername = Console.ReadLine();
        Console.WriteLine("To continiout please enter your password");
        string typePassword = Console.ReadLine();
        Customer currentCustomer = InfoChecker(typeUsername, typePassword);
        if(currentCustomer != null)
        {
            Console.WriteLine($"Welcome to our bank Mr {currentCustomer.Username}");
            ProcessMenu(currentCustomer);
        }
    }
}

void ProcessMenu(Customer currentCustomer)
{
    Console.WriteLine("To withdraw money type 1");
    Console.WriteLine("To insert money type 2");
    Console.WriteLine("To check balance type 3");
    Console.WriteLine("To exit type 4");
    int response = Convert.ToInt32(Console.ReadLine());
    if (response == 1)
    {
        int amount = Convert.ToInt32(Console.ReadLine());
        currentCustomer.Withdraw(amount);

    }
    else if (response == 2)
    {
        int amount = Convert.ToInt32(Console.ReadLine());
        currentCustomer.AddMoney(amount);
    }
    else if (response == 3) 
    { 
        
    }
}


if (Mete is SpecialCustomer specialMete)
{
    specialMete.TakeCredit();
}
Console.WriteLine("Hello world");
Mete.AddMoney(99);
Mete.ShowInfo();


Customer CustomerCreator(string name, string sirname , int balance , string username , string password)
{
    if(balance > 10000)
    {
        return new SpecialCustomer(name,sirname,balance,username,password);
    }
    else
    {
        return new Customer(name,sirname,balance,username,password);
    }
}






