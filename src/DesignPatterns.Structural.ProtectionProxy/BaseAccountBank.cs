using System;

namespace DesignPatterns.Structural.ProtectionProxy
{
    public  interface BaseAccountBank
    {
        // Parameter: decimal amount
        public void WithDrawMoney(decimal amount);
        
        // Parameter: decimal amount
        public void DepositMoney(decimal amount);
        public void GetName();

        // Parameter: string name
        public void SetName(string name);
        public void GetSurName();

        // Parameter: string surName
        public void SetSurName(string surName);
        public void GetAccountStatus();

        // Parameter: decimal accountStatus
        public void SetAccountStatus(decimal accountStatus);
        public bool Cancel();
        
    }
}
