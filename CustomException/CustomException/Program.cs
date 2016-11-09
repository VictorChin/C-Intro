using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount Bob = new BankAccount("BobAccount");
            Bob.Deposit(2000);
            Bob.Withdraw(301.35m);
            Bob.Withdraw(1301);
           

            Console.WriteLine(Bob);
            
        }
    }

    public class BankAccount
    {
        const int OverDrawnLimit = -300;
        private string _accountName;

        public string AccountName//property
        {
            get { return _accountName; }
            private set {
                if (value.Length < 5) { throw new BankAccountException(); }
                _accountName = value; }
        }
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            private set { if(value < OverDrawnLimit) { throw new BankAccountException(); }
                _balance = value; }
        }
        public BankAccount(string accountName)//constructor here
        {
            this.AccountName = accountName;
            this.Balance = 0;
        }
        public void Deposit(decimal amount) => this.Balance += amount;
        public void Withdraw(decimal amount) => this.Balance -= amount;
        public override string ToString()=>$"Account: {AccountName} has {Balance:c2}";
        



    }

    [Serializable]
    internal class BankAccountException : Exception
    {
        public BankAccountException()
        {
        }

        public BankAccountException(string message) : base(message)
        {
        }

        public BankAccountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BankAccountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
