using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyDPDemo.GlobalInterfaces;

namespace ProxyDPDemo.Models
{
    public class RealBankAccount : IBankAccount
    {
        private double _balance;

        public string Deposit(double amount)
        {
            _balance += amount;
            return $"Deposited Rs. {amount} to your account Successfully";
        }

        public string Withdraw(double amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                return $"Withdrawn Rs. {amount} from your account Successfully";
            }
            return $"Insufficient Balance";
        }

        public double GetBalance() { return _balance; }
    }
}
