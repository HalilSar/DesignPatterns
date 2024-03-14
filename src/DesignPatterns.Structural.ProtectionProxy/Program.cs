using System;

namespace DesignPatterns.Structural.ProtectionProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseAccountBank accountBank = new AccountBank("Abraham", "Yellowstone", 1000000000000000000);
            BaseAccountBank myaccount = new MyAccountBankProxy(accountBank);
            myaccount.DepositMoney(2500000000000000);
            myaccount.WithDrawMoney(5000000);
            myaccount.GetAccountStatus();

        }
    }
}
