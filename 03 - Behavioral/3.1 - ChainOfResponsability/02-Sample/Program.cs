using System;

namespace _02_Sample
{
    class Program
    {
        /*
         * 
         * O padrão de design da Cadeia de Responsabilidade evita acoplar o remetente de uma solicitação
         * ao seu receptor, dando a mais de um objeto a chance de lidar com a solicitação.
         * Esse padrão encadeia os objetos receptores e passa a solicitação ao longo da cadeia até que um objeto a trate.
         * */
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Cadeia ou seguencia de responsabilidades Sample 2!");

            StepBase st1 = new Step1();
            st1
                .AndThen(new Step2())
                .AndThen(new Step3())
                .AndThen(new Step4());

            Console.WriteLine(await st1.ExecuteAsync().ConfigureAwait(false));
            Console.ReadLine();
        }
    }
}
