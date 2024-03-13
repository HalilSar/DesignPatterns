using System;

namespace DesignPatterns.Structural.ProtectionProxy
{
    public class AccountBank : BaseAccountBank
    {
        private string name;
        private string surName;
        private decimal accountStatus = 0;
        private bool cancelled = false;
        public AccountBank(string name, string SurName, decimal money)
        {
            SetName(name);
            SetSurName(name);
            SetAccountStatus(money);
        }
        public bool Cancel()
        {
            this.cancelled = true;
            return cancelled;
        }

        public void DepositMoney(decimal amount)
        {
            accountStatus += amount;
        }

        public void GetAccountStatus()
        {
            Console.WriteLine("Your Account Balance : "+ accountStatus);
        }

        public void GetName()
        {
            Console.WriteLine("Name :" + this.name);
        }

        public void GetSurName()
        {
            Console.WriteLine("Surname :" + this.surName);
            
        }

        public void SetAccountStatus(decimal accountStatus)
        {
            this.accountStatus=accountStatus;
        }

        public void SetName(string name)
        {
           this.name = name;
        }

        public void SetSurName(string surName)
        {
            this.surName = surName;
        }

        public void WithDrawMoney(decimal amount)
        {
            if (accountStatus-amount > 0)
            {
                SetAccountStatus(accountStatus - amount);
                Console.WriteLine("Transaction completed.");
            }
            else
            {
                throw new Exception("Insufficient funds in your account.");
            }
        }
            

       
    }
}
