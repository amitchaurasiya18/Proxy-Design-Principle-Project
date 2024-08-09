using ProxyDPDemo.GlobalInterfaces;
using ProxyDPDemo.Models;

public class Program
{
    public static void Main(string[] args)
    {
        IBankAccount newAccount = new ProxyBankAccount("12345");

        Console.WriteLine($"Balance is: {newAccount.GetBalance()}");
        newAccount.Deposit(10000);
        Console.WriteLine($"Balance is: {newAccount.GetBalance()}");
        newAccount.Withdraw(3284);
        Console.WriteLine($"Balance is: {newAccount.GetBalance()}");
    }
}