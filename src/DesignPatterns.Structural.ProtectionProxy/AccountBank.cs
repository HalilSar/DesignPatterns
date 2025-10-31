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

        // return bool
        public bool Cancel()
        {
            this.cancelled = true;
            return cancelled;
        }

        // Parameter: decimal amount
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

        // Parameter : decimal accountStatus
        public void SetAccountStatus(decimal accountStatus)
        {
            this.accountStatus=accountStatus;
        }

        // Parameter : string name
        public void SetName(string name)
        {
           this.name = name;
        }

        // Parameter : string surName
        public void SetSurName(string surName)
        {
            this.surName = surName;
        }

        // Parameter : decimal amount
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
