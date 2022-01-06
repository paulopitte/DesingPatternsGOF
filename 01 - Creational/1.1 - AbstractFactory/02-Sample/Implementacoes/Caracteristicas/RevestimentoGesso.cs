using _02_Sample.Interfaces.Caracteristicas;
using System;

namespace _02_Sample.Implementacoes.Caracteristicas
{
    public class RevestimentoGesso : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Edificação Revestida por Gesso.");
        }
    }
}
