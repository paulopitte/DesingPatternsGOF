using System;

namespace _01_Sample
{


    /**
        O padrão de design do adaptador converte a interface de uma classe em outra interface que os clientes esperam. 
        Este padrão de design permite que as classes trabalhem juntas de outra forma devido a interfaces incompatíveis.
     * **/
    internal sealed class Program
    {
        private static void Main()
        {
            Console.WriteLine("Adapter!");
            AdapterService.ExecutionOperation();
            Console.ReadKey();
        }





    }
}