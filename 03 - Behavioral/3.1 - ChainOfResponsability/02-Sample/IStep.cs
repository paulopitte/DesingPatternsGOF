using System.Threading.Tasks;

namespace _02_Sample
{
    /// <summary>
    /// Representa um passo  
    /// </summary>
    public interface IStep
    {
        /// <summary>
        /// Define o próximo passo
        /// </summary>
        /// <param name="step"></param>
        /// <returns></returns>
        IStep AndThen(IStep step);


        /// <summary>
        /// Realiza o processamento referente ao passo e retorna o resultado
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderParams"></param>
        /// <returns></returns>
         Task<string> ExecuteAsync();
    }
}
