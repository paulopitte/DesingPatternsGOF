 
namespace _02_Sample.Implementacoes.Caracteristicas
{
    using Interfaces.Caracteristicas;
    using System;

    public class FundacaoRocha : IFundacao
    {
        public void Composicao()
        {
            Console.WriteLine("Edificação Contruida Sobre a Rochas e COncretos.");

        }
    }
}
