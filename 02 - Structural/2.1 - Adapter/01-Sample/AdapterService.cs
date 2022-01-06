namespace _01_Sample
{
    public class AdapterService
    {
        public static void ExecutionOperation()
        {

            var logDefault = new TransactionService(new Logger());
            logDefault.StartTransaction();

            var logCuston = new TransactionService(new LoggerAdapter( new LoggerMasterService()));
            logCuston.StartTransaction();

        }
    }
}
