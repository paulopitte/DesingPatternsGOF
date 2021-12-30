namespace _02_Sample
{
    using Implementacoes;
    using Interfaces;

    internal sealed class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contrutora Pitte S/A!");

            IFabricaContrucaoEdificacao fabrica;
            Console.WriteLine("Escolha o tipo de Edificação desejada!");
            Console.WriteLine("1 - Casa");
            Console.WriteLine("2 - Edificio (Apartamento)");

            switch (Console.ReadLine())
            {
                case "1":
                    fabrica = new ContruirCasa();
                    break;
                case "2":
                    fabrica = new ContruirEdificio();
                    break;
                default:
                    Console.WriteLine("Selecione entre Casa e Edificio");
                    break;
            }

            Console.ReadKey();
        }
    }
}