namespace _01_Sample
{
    public class AdapterService
    {
        public static void ExecutionOperation()
        {

            TransactionService logDefault = new(new Logger());
            logDefault.StartTransaction();

            var logCuston = new TransactionService(new LoggerAdapter( new LoggerMasterService()));
            logCuston.StartTransaction();

        }
    }
}
