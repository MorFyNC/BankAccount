using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Class
{
    public class BankAccount
    {
        decimal _balance = 0;
        public decimal Balance { get { return _balance; } set {  _balance = value; } }

        public string AccountNumber { get; set; }

        public string Password { get; set; }

        public delegate void BalanceOperation(BankAccount account, int sum);

        public BankAccount(string accountNumber, string password)
        {
            AccountNumber = accountNumber;
            Password = password;
        }

        public void Translation(BankAccount account, int sum)
        {
            if (_balance - sum >= 0)
            {
                account.Balance += sum;
                _balance -= sum;
            }
            else
            {
                Console.WriteLine("Not enough money :(");
            }
        }
    }
}
