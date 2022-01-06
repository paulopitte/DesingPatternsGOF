using System;
using System.Threading.Tasks;

namespace _02_Sample
{
    public class Step3 : StepBase
    {
        public override async Task<string> ExecuteAsync()
        {
            Console.WriteLine("EXECUTANDO STEP 3");
            return await base.ExecuteAsync().ConfigureAwait(false);
        }
    }
}
