namespace _02___Sample.Domain.Base
{
    using System;
    using System.Data;
    using ValueObj;

    public abstract class TransactionBase
    {

        public TransactionType TransactionType { get; set; }
        public Guid TransactionId { get; }
        public DateTimeOffset CreateAt { get; }
        private const short GMT = -3;
        public Decimal Amount { get; }
        public TransactionStatusType TransactionStatusType { get; private set; }


        public TransactionBase(TransactionType transactionType, decimal amount)
        {
            TransactionType = transactionType;
            Amount = amount;
            CreateAt = DateTime.UtcNow.AddHours(GMT);
            TransactionId = Guid.NewGuid();
            TransactionStatusType = TransactionStatusType.Pending;
        }

        public bool SetStatusInProgress()
        {
            StatusTransitionValidate(TransactionStatusType.InProgress);

            this.TransactionStatusType = TransactionStatusType.InProgress;

            return true;
        }

        public bool SetStatusAuthorized()
        {
            StatusTransitionValidate(TransactionStatusType.Authorized);

            this.TransactionStatusType = TransactionStatusType.Authorized;

            return true;
        }

        public bool SetStatusUnauthorized()
        {
            StatusTransitionValidate(TransactionStatusType.Unauthorized);

            this.TransactionStatusType = TransactionStatusType.Unauthorized;

            return true;
        }


        private bool StatusTransitionValidate(TransactionStatusType desiredTransactionStatusType)
        {
            if (this.TransactionStatusType.Equals(desiredTransactionStatusType))
                throw new ConstraintException("Sem transação de status transitado.");

            if ((int)this.TransactionStatusType < (int)desiredTransactionStatusType)
                throw new ConstraintException("Transação de status Inválida.");


            if ((int)this.TransactionStatusType <= 1)
                throw new ConstraintException("Transação Inválida de status para finalização do processo.");

            return true;
        }


    }
}
