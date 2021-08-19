using System;

namespace MySuperBank
{
    public class TransAction
    {
        public decimal Amount { get;}
        public DateTime Date { get;  }
        public  string Notes { get; }

        public TransAction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }
}