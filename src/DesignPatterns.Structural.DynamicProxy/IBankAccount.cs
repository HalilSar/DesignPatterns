namespace DesignPatterns.Structural.DynamicProxy
{
    public interface IBankAccount
    {
        void WithDrawMoney(decimal money);
        void DepositeMoney(decimal money);
        void SetName(string name);
        void GetName();
        void GetSurName();
        void SetSurName(string surName);
        void GetAccountStatus();
        void SetAccountStatus(decimal money);
        void Cancel();
        bool CancelStatus();
    }
}
