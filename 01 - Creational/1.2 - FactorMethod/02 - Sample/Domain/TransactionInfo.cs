using System;

namespace _02___Sample.Domain
{
    using ValueObj;
    public class TransactionInfo
    {
        public Guid TransactionId { get; }
        public DateTimeOffset CreateAt { get; }
        public decimal Amount { get; }
        public TransactionStatusType TransactionStatusType { get; }

        public TransactionInfo(Guid transactionId, DateTimeOffset createAt, decimal amount, TransactionStatusType transactionStatusType)
        {
            TransactionId = transactionId;
            CreateAt = createAt;
            Amount = amount;
            TransactionStatusType = transactionStatusType;
        }
    }
}
