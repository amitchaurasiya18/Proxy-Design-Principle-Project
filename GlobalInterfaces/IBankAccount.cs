using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProxyDPDemo.GlobalInterfaces
{
    public interface IBankAccount
    {
        public string Deposit(double amount);
        public string Withdraw(double amount);
        public double GetBalance();
    }
}
