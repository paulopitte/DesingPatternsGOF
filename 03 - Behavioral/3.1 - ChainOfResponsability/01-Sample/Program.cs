using System;

namespace _01_Sample
{
    /*
 * 
 * O padrão de design da Cadeia de Responsabilidade evita acoplar o remetente de uma solicitação
 * ao seu receptor, dando a mais de um objeto a chance de lidar com a solicitação.
 * Esse padrão encadeia os objetos receptores e passa a solicitação ao longo da cadeia até que um objeto a trate.
 * */

   internal sealed class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadeia de responsabilidade sample 1!");

            Manipulador pA = new PersonagemA();
            Manipulador pB = new PersonagemB();
            PersonagemC pC = new ();

            // executa a cadeia de chamadas conforme seguencia de negocio
            pA.defineSucessor(pB);
            pB.defineSucessor(pC);


            int[] requisicoes = { 5, 3, 7, 10, 23, 29 };


            foreach (var req in requisicoes)
                pA.Convoca(req);



            Console.ReadKey();
        }
    }
}
