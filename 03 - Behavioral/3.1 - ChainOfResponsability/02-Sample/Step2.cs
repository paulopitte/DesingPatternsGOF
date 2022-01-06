using System;
using System.Threading.Tasks;

namespace _02_Sample
{
    public class Step2 : StepBase
    {
        public override async Task<string> ExecuteAsync()
        {            
            Console.WriteLine("EXECUTANDO STEP 2");
            return await base.ExecuteAsync().ConfigureAwait(false);
        }
    }
}
