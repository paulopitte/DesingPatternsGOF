using System;

namespace _01_Sample
{

    // Adaptee class -> Adaptação que será utilizada para substituir o Target contendo as regras base ou iniciais.
    public interface ILoggerMasterService
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
    internal class LoggerMasterService : ILoggerMasterService
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado com novas regras de negocio - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Log Customizado com novas regras de negocio - " + exception.Message);
        }
    }
}
