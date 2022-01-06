
using System;

namespace _01___Sample
{
    using Personagens;

    class Program
    {
        static void Main(string[] args)
        {
            var factoryMethod = new FactoryMethod();


            Console.WriteLine("Super Mario  |  Pica-Pau   |   SubZero   |   Jaspion");
            Console.WriteLine();
            Console.WriteLine("Esolha um Personagem!");
            string escolhido = Console.ReadLine();

            IPersonagem personagem = factoryMethod.Escolher_Personagem(escolhido);

            Console.WriteLine();
            Console.WriteLine("Voçê vai jogar com: ");
            personagem.Escolhido();


            Console.ReadLine();
        }
    }
}
