using System;

namespace _01_Sample
{
    // Target class -> Funcionalidade BASE inicial raiz, regras de negocio etc...
    // Esta classe será substituida atraves do padrao Adpter
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }


    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log com regras de negocio padrão - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Log com regras de negocio padrão - " + exception.Message);
        }
    }
}
