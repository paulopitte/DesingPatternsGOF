
namespace _02___Sample.Manager.Factory
{    
    using Domain.ValueObj;
    using Processors;
    using Processors.Interfaces;
    using System;

    public static class TransactionProcessorFactory
    {
        public static ITransactionProcessor CreateTransactionProcessor(TransactionType transactionType)
        {
            return transactionType switch
            {
                TransactionType.CreditCard => new CrediCardTransactionProcessor(),
                TransactionType.Debit => new DebitTransactionProcessor(),
                TransactionType.PaymentSlip => new PaymentSlipTransactionProcessor(),
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}
