namespace _01_Sample
{

    //Client consumidor do Target class
    internal class TransactionService
    {
        private readonly ILogger _logger;

        public TransactionService(ILogger logger)
        {
            _logger = logger;
        }

        public void StartTransaction()
        {
            // execução da Transação
            _logger.Log("Transação realizada");
        }
    }
}
