namespace _02___Sample.Domain
{
    using Base;
    using ValueObj;

    public sealed class DebitTransaction : TransactionBase
    {
        public string BankName { get; }

        public DebitTransaction(decimal amount, string bankName) : base(TransactionType.Debit, amount) =>
            BankName = bankName;

    }
}
