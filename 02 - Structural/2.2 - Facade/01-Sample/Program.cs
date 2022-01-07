using System;

namespace _01_Sample
{
    class Program
    {
        /*
         * A Ideia é criar uma fachada ou tradução no modelo de objs para o mundo externo para interpretação das 
         *  funcinalidades gerando uma personalização ou adaptação para no caso consultas em outros sistemas legados.
         * Funcionalidade: Muito Utilizado
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Patterner Facade Sample 1 !");
            ExecucaoFacade.Executar();
            Console.ReadKey();
        }
    }
}
