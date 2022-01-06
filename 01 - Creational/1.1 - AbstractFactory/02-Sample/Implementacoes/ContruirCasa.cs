using _02_Sample.Implementacoes.Caracteristicas;
using _02_Sample.Interfaces;
using System;

namespace _02_Sample.Implementacoes
{
    public class ContruirCasa : IFabricaContrucaoEdificacao
    {
        public ContruirCasa() => Contruir();

        public void Contruir()
        {
            Console.WriteLine("Caracteristicas da Contrução!");

            FundacaoRocha fundacaoRocha = new FundacaoRocha();
            fundacaoRocha.Composicao();


            EnergiaBaseSolar energiaBaseSolar = new EnergiaBaseSolar();
            energiaBaseSolar.Composicao();


            RevestimentoConcreto revestimentoConcreto = new RevestimentoConcreto();
            revestimentoConcreto.Composicao();

            Console.WriteLine("Casa (100%) Construida pronta para Entrega!");
        }
    }

}
