using System;

namespace _01_Sample
{
    // Adapter class -> AQUI DE FATO É A IMPLEMENTAÇÃO DO PATTERN EM FIM,
    // USANDO A INTERFACE ORIGINAL ILOGGE COM A ADAPTAÇÃO A INTERFACE ADAPTEE À INTERFACE DE DESTINO.
    
    public class LoggerAdapter : ILogger
    {

        private readonly ILoggerMasterService _loggerMasterService;
        public LoggerAdapter(ILoggerMasterService loggerMasterService) =>       
            _loggerMasterService = loggerMasterService;
     

        public void Log(string message) =>  // nesse momento é passado a responsabilidade para clase adaptee onde contem as novas regras     
           _loggerMasterService.LogInfo(message);
       

        public void LogError(Exception exception) =>    // nesse momento é passado a responsabilidade para clase adaptee onde contem as novas regras     
           _loggerMasterService.LogException(exception);
        
    }
}
