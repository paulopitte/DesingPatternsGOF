using System;
using System.Threading.Tasks;

namespace _02_Sample
{
    public class Step1 : StepBase
    {
        public override async Task<string> ExecuteAsync()
        {
            Console.WriteLine("EXECUTANDO STEP 1");
            return await base.ExecuteAsync().ConfigureAwait(false);
        }
    }
}
