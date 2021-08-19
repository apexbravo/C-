using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace MySuperBank
{
    public class BankAccount
    {
        public  string Number { get; }
        public  string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var ITEM in allTransActions)
                {
                    balance += ITEM.Amount;
                }

                return balance;
            }
        }
        private static int accountNumberSeed = 1234567890;

        private List<TransAction> allTransActions = new List<TransAction>();
        private decimal minimumBalance;

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Deposit");
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < minimumBalance)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new TransAction(-amount, date, note);
            allTransActions.Add(withdrawal);
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");

            }
            var deposit = new TransAction(amount, date, note);
            allTransActions.Add(deposit);

        }


        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();
            report.Append("Date\t\tAmount\tNote\n");
            foreach (var item in allTransActions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }


    }
}