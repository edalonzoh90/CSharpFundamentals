namespace POOExample
{
    //Inherit

    public class LineOfCreditAccount : BankAccount
    {
        //Use 3 params constructor
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        {
        }

        //Overriding the base class implementation
        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                // Negate the balance to get a positive interest charge:
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }

        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
        isOverdrawn
        ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
        : default;
    }
}

