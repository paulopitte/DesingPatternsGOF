using System;

namespace _02___Sample
{
    using Domain;
    using Domain.ValueObj;
    using Manager.Factory;

    /*
    *  Factory Method
    *
    *  Define uma interface de criação de objeto, mas deixa a sua subclasse decidir qual classe deve ser instânciada
    *  É considerado um "Construtor virtual"
    */

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Processando das Transações!");
            Console.WriteLine();


            #region CreditCard Transaction

            var creditCardTransactionProcessor =
                TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.CreditCard);

            var creditCardTransaction = new CreditCardTransaction(
                1000, "Paulo Pitte", "222", "1111222233334444");

            var creditCardTransactionInfo = creditCardTransactionProcessor.Authorize(creditCardTransaction);

            Console.WriteLine($"{creditCardTransactionInfo.Amount} | {creditCardTransactionInfo.CreateAt:g} | " +
                              $"{creditCardTransactionInfo.TransactionId} | {creditCardTransactionInfo.TransactionStatusType}");

            #endregion

            #region Debit Transaction

            var debitTransactionProcessor =
                TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.Debit);

            var debitTransaction = new DebitTransaction(1300, "Banco Inter");

            var debitTransactionInfo = debitTransactionProcessor.Authorize(debitTransaction);

            Console.WriteLine($"{debitTransactionInfo.Amount} | {debitTransactionInfo.CreateAt:g} | " +
                              $"{debitTransactionInfo.TransactionId} | {debitTransactionInfo.TransactionStatusType}");

            #endregion


            Console.ReadKey();

        }
    }
}
