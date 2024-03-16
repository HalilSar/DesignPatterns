namespace DesignPatterns.Structural.DynamicProxy
{
    public class BankAccount : IBankAccount
    {
        private string name;
        private string surName;
        private decimal accountStatus = 0;
        private bool canceled = false;

        public BankAccount(string name, string surName, decimal accountStatus, bool canceled)
        {
            SetName(name);
            SetSurName(surName);
            SetAccountStatus(accountStatus);
        }
        public void Cancel()
        {
            this.canceled = true;
        }

        public bool CancelStatus()
        {
           return canceled ;
        }

        public void DepositeMoney(decimal money)
        {
            this.accountStatus += money;
        }

        public void GetAccountStatus()
        {
            System.Console.WriteLine("Account Status: " + this.accountStatus);
        }

        public void GetName()
        {
            System.Console.WriteLine("Name: "+ this.name );
        }

        public void GetSurName()
        {
            System.Console.WriteLine("Name: " + this.surName);
        }

        public void SetAccountStatus(decimal money)
        {
           this.accountStatus = money;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSurName(string surName)
        {
             this.surName = surName;
        }

        public void WithDrawMoney(decimal money)
        {
            if (money > this.accountStatus) this.accountStatus -= money;

            else System.Console.WriteLine("Insufficient funds in your account.");
        }
    }
}
