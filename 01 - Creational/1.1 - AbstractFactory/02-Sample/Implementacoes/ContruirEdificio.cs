using _02_Sample.Implementacoes.Caracteristicas;
using _02_Sample.Interfaces;
using System;

namespace _02_Sample.Implementacoes
{
    public class ContruirEdificio : IFabricaContrucaoEdificacao
    {
        public ContruirEdificio() => Contruir();

        public void Contruir()
        {
            Console.WriteLine("Caracteristicas da Contrução!");

            var fundacaoRocha = new FundacaoAreia();
            fundacaoRocha.Composicao();


            var energiaBaseSolar = new EnergiaBaseConcessionaria();
            energiaBaseSolar.Composicao();


            var revestimentoConcreto = new RevestimentoGesso();
            revestimentoConcreto.Composicao();

            Console.WriteLine("Apartamento (10%) Construida, em fase de Contruição!");
        }
    }
}
