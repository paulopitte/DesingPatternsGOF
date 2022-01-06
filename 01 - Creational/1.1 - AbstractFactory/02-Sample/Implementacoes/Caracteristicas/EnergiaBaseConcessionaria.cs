namespace _02_Sample.Implementacoes.Caracteristicas
{
    using Interfaces.Caracteristicas;
    using System;

    public class EnergiaBaseConcessionaria : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Eletricidade da Edificação Sustentado pela Concessionaria Bandeirante S/A.");
        }
    }
}
