using System;

namespace _01_Sample
{
    class Program
    {
        /*
         * 
         * O padrão de projeto Composto compõe objetos em estruturas de árvore para representar hierarquias parte-todo. 
         * Esse padrão permite que os clientes tratem objetos individuais e composições de objetos uniformemente.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Implement Pattern Compose Sample 1!");
            ExecucaoComposite.Executar();
            Console.ReadKey();
        }
    }
}
