using _02_Sample.Interfaces.Caracteristicas;
namespace _02_Sample.Implementacoes.Caracteristicas
{
    public class RevestimentoConcreto : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Edificação Revestida por Reboco e Textura.");
        }
    }
}
