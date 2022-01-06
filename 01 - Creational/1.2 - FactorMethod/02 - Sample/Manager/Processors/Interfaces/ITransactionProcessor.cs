namespace _02___Sample.Manager.Processors.Interfaces
{
    using Domain;
    using Domain.Base;
    public interface ITransactionProcessor
    {
        TransactionInfo Authorize(TransactionBase transaction);
    }
}
