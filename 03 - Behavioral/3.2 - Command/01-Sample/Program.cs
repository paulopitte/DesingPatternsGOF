using System;

namespace _01_Sample
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            /*
             * O padrão de design Command encapsula uma solicitação como um objeto, permitindo, assim, parametrizar clientes com diferentes solicitações, 
             * solicitações de fila ou log e oferecer suporte a operações que podem ser desfeitas.
             */
            Console.WriteLine("Command -  Sample 1!");
            ExecucaoCommand.Executar();
            Console.ReadKey();
        }
    }
}
