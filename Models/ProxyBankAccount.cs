using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyDPDemo.GlobalInterfaces;

namespace ProxyDPDemo.Models
{
    public class ProxyBankAccount : IBankAccount
    {
        private RealBankAccount _realBankAccount;
        private string _password;

        public ProxyBankAccount(string password)
        {
            _realBankAccount = new RealBankAccount();
            _password = password;
        }

        private bool Authenticate(string password)
        {
            return _password == password;
        }

        public string Deposit(double amount)
        {
            Console.Write($"Enter password to deposit Rs.{amount}: ");
            string passwordInput = Console.ReadLine();

            if (Authenticate(passwordInput))
            {
                _realBankAccount.Deposit(amount);
                return $"Deposited Rs. {amount} to your account Successfully";
            }

            return $"Authentication failed for Deposit";
        }

        public string Withdraw(double amount)
        {
            Console.Write($"Enter password to Withdraw Rs.{amount}: ");
            string passwordInput = Console.ReadLine();

            if (Authenticate(passwordInput))
            {
                _realBankAccount.Withdraw(amount);
                return $"Withdrawn Rs. {amount} from your account Successfully";
            }

            return $"Authentication failed for withdrawl";
        }

        public double GetBalance()
        {
            Console.Write("Enter password to Check Balance: ");
            string passwordInput = Console.ReadLine();

            if (Authenticate(passwordInput))
            {
                return _realBankAccount.GetBalance();
            }

            Console.WriteLine("Authentication failed...");
            return 0;
        }
    }
}
