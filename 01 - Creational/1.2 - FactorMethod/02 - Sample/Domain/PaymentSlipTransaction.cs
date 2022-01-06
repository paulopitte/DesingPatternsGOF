using System;

namespace _02___Sample.Domain
{
    using Base;
    using ValueObj;

    public sealed class PaymentSlipTransaction : TransactionBase
    {
        public string DocumentNumber { get; }
        public string BarCode { get; }
        public DateTime DueDate { get; }

        public PaymentSlipTransaction(decimal amount, string documentNumber, string barCode, DateTime dueDate)
            : base(TransactionType.PaymentSlip, amount)
        {
            DocumentNumber = documentNumber;
            BarCode = barCode;
            DueDate = dueDate;
        }
    }

}
