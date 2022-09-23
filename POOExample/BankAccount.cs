namespace POOExample
{
    //BankAccout Abstraction
    public class BankAccount
    {
        //Encapsulation of the components

        private static int accountNumberSeed = 1234567890;

        public string Number { get; }

        public string Owner { get; set; }

        private List<Transaction> allTransactions = new List<Transaction>();

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        // The value cannot be changed after the object is constructed
        private readonly decimal _minimumBalance;

        // Constructor chaining - One constructor call another
        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            Owner = name;
            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transaction? withdrawal = new(-amount, date, note);
            allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                allTransactions.Add(overdraftTransaction);
        }

        // Protected - Can be called only from derived classes. 
        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        //A virtual method is a method where any derived class may choose to reimplement.
        //The derived classes use the override keyword to define the new implementation.
        public virtual void PerformMonthEndTransactions() { }
    }
}

