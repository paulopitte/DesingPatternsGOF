using System;
using System.Threading.Tasks;

namespace _02_Sample
{
    public class Step4 : StepBase
    {
        public override async Task<string> ExecuteAsync()
        {
            await Task.CompletedTask;

           // Console.WriteLine("EXECUTANDO STEP 4");
            return "EXECUTANDO STEP 4";
        }
    }
}
