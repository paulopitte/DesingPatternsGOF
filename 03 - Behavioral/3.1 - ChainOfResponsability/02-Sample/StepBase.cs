using System.Threading.Tasks;

namespace _02_Sample
{
    public abstract class StepBase : IStep
    {

        private IStep _next;

        /// <summary>
        /// Define o próximo passo (Next)
        /// </summary>
        /// <param name="step"></param>
        /// <returns></returns>
        public IStep AndThen(IStep step)
        {
            _next = step;
            return _next;
        }

        /// <summary>
        /// Realiza o processamento referente ao próximo passo e retorna o resultado
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public virtual async Task<string> ExecuteAsync()
        {
            if (_next == null)
                return null;

            return await _next.ExecuteAsync().ConfigureAwait(false);
        }

     
    }
}
