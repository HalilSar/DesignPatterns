using System;

namespace DesignPatterns.Structural.ProtectionProxy
{
    public class OtherAccountBankProxy : BaseAccountBank
    {
        private BaseAccountBank accountBank;
        public OtherAccountBankProxy(BaseAccountBank accountBank)
        {
            this.accountBank = accountBank;
        }

        
        public bool Cancel()
        {
            throw new Exception("You do not permission.");
        }

        public void DepositMoney(decimal amount)
        {
            this.accountBank.DepositMoney(amount);
        }

        public void GetAccountStatus()
        {
           this.accountBank.GetAccountStatus();
        }

        public void GetName()
        {
           this.accountBank.GetName();
        }

        public void GetSurName()
        {
            accountBank.GetSurName();

        }

        public void SetAccountStatus(decimal accountStatus)
        {
            throw new Exception("You do not permission.");
        }

        public void SetName(string name)
        {
            throw new Exception("You do not permission.");
        }

        public void SetSurName(string surName)
        {
            throw new Exception("You do not permission."); 

        }

        public void WithDrawMoney(decimal amount)
        {
           this.accountBank.WithDrawMoney(amount);
        }
    }
}
