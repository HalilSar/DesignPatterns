using System;

namespace DesignPatterns.Structural.ProtectionProxy
{
    public  interface BaseAccountBank
    {
        public void WithDrawMoney(decimal amount);
        public void DepositMoney(decimal amount);
        public void GetName();
        public void SetName(string name);
        public void GetSurName();
        public void SetSurName();
        public void GetAccountStatus();
        public void SetAccountStatus(decimal accountStatus);
        public bool Cancel();
        
    }
}
