using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Account
    {
        private int acid;

        public int AccountId
        {
            get { return acid; }
            set { acid = value; }
        }

    }

    interface IAccount
    {
        void Deposit(double amt);
        void WithDraw(double amt);

        double Balance { get; set; }
    }

    interface IOverdraft
    {
        void Overdraft(double amt);
    }
    class SBAccount : Account, IAccount
    {
        double balance = 0;
        
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public void Deposit(double amt)
        {
            Console.WriteLine("Depositing  {0} into SB account id {1}",amt,AccountId);
        }

        public void WithDraw(double amt)
        {
            Console.WriteLine("Withdrawing  {0} into SB account id {1}", amt, AccountId);
        }
    }

    class SalaryAccount : Account, IAccount,IOverdraft
    {
        double balance = 0;

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public void Deposit(double amt)
        {
            Console.WriteLine("Depositing  {0} into salary account id {1}", amt, AccountId);
        }

        public void Overdraft(double amt)
        {
            Console.WriteLine("Overdrafting  {0} into salary account id {1}", amt, AccountId);
        }

        public void WithDraw(double amt)
        {
            Console.WriteLine("Withdrawing  {0} into salary account id {1}", amt, AccountId);
        }
    }

    class Bank
    {
        public void Transfer(IAccount sa,IAccount ac)
        {
            sa.WithDraw(1000);
            ac.Deposit(1000);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SBAccount sb1 = new SBAccount();
            sb1.Balance = 10000;
            sb1.AccountId = 1111;

            SalaryAccount salac = new SalaryAccount();
            salac.AccountId = 2222;
            salac.Balance = 5000;


            Bank bk = new Bank();
            bk.Transfer(salac, sb1);
        }
    }
}
