namespace _02_Sample.Implementacoes.Caracteristicas
{
    using Interfaces.Caracteristicas;
    public class EnergiaBaseSolar : IEnergia
    {
       
        public void Composicao()
        {
            System.Console.WriteLine("Eletricidade da Edificação Sustentado pelo sistema de placas Solares.");
        }
    }
}
