namespace POOExample
{
    //Inherit

    public class GiftCardAccount : BankAccount
    {
        private readonly decimal _monthlyDeposit = 0m;
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;

        //Overriding the base class implementation
        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }

    }
}

