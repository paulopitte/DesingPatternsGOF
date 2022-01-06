using System;

namespace _01_Sample
{
    // Adapter class -> adapta a interface Adaptee à interface de destino.
    
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
