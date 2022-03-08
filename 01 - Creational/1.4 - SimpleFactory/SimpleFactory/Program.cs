using System;

namespace SimpleFactory
{

    /*
     * Simple Factory é um padrão nao mencionado no livro do Gof, porem é um dos padroes mais utilizados hoje.
     * 
     * 1 - O Objivo dessa cara é criar objetos sem expor a lógica de instnciação ao client.
     * 
     * 2 - Referece ao obj recém-criado por meio de uma interface comum.
     * 
     * Descrevendo um caso de uso...
     * 
     * 1 - Client precisa de um novo produto, mas ao inves de criar diretamente por uma instancia utilizando o operador (new)
     * pede ao objeto Factory um novo produto, fornencendo para fabrica o tipo de objeto que necessita.
     * 
     * 2 - entao a fabrica instancia um novo produto concreto, e em seguida retorna ao cliente o produto recém criado(convertido para uma classe de produto abstrata)
     * 
     * 3 - o cliente por sua vez utiliza desse retorno (produto) abstrato sem estar ciente de sua implementação concreta.
     * 
     * */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========= Simple Factory ======\n");
            Console.WriteLine("Informe a implementação (1) ou (2) ");
            var implementationChoose = Console.ReadLine().ToUpper();
            try
            {
                var implementationConcrete = Factory.Create(implementationChoose) as AbstractClass;

                Console.WriteLine(implementationConcrete.ToString());

                Console.WriteLine($" Execução da implementação {implementationChoose} concluda. ");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro :" + ex.Message);
            }
            Console.ReadLine();

        }
    }
}
