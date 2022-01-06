namespace AbstractFactoryPersonal
{
    using _01_Sample.Domain.Base;
    using _01_Sample.Domain.ValueObj;
    using _01_Sample.Factories.AbstractFactory;
    using System;

    /**
     * PROVÊ UMA INTERFACE PARA CRIAÇÃO DE FAMILHAS DE OBJs RELACIONADOS
     * OU DEPENDENTES SEM ESPECIFICAR A SUA CLASSE CONCRETA.
     * **/
    internal sealed class Program
    {
        private static void Main()
        {
            Console.WriteLine("Abstract Factory - Fábrica de Instrumentos Musicais!");

            // Criei 3 fabricas abstratas recebendo um tipo especifico
            var violaofactory = InstrumentoCordaAbstractFactory.CriaFabrica(InstrumentoType.Violao);
            var guitarrafactory = InstrumentoCordaAbstractFactory.CriaFabrica(InstrumentoType.Guitarra);
            var contraBaixoFactory = InstrumentoCordaAbstractFactory.CriaFabrica(InstrumentoType.ContraBaixo);

            var violao1 = violaofactory.CriaInstrumento(ViolaoType.Takamine1ER4);
            var violao2 = violaofactory.CriaInstrumento(ViolaoType.TakamineStudio);
            var guitarra1 = guitarrafactory.CriaInstrumento(GuitarraType.IbanezGRG250);
            var guitarra2 = guitarrafactory.CriaInstrumento(GuitarraType.JacksonJ22);
            var guitarra3 = guitarrafactory.CriaInstrumento(GuitarraType.IbanezEVO);
            var contraBaixo1 = contraBaixoFactory.CriaInstrumento(ContraBaixoType.Fender);

            PrintInfo(violao1);
            PrintInfo(violao2);
            PrintInfo(guitarra1);
            PrintInfo(guitarra2);
            PrintInfo(guitarra3);
            PrintInfo(contraBaixo1);
            Console.ReadKey();

        }




        private static void PrintInfo(InstrumentoCordaBase instrumentoCordaBase)
        {
            Console.WriteLine($"Total cordas: {instrumentoCordaBase.ObterQuantidadeCordas()} | Modelo: { instrumentoCordaBase.Modelo} | Tipo: {instrumentoCordaBase.InstrumentoType}\n");

            var index = instrumentoCordaBase.ObterQuantidadeCordas();

            foreach (var nota in instrumentoCordaBase.ListarNotas())
            {
                Console.WriteLine($"{index--}º: {nota.Info}");
            }

            Console.WriteLine("------------------------\n\n");
        }

    }
}