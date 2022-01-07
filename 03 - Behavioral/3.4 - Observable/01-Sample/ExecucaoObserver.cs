using System;

namespace _01_Sample
{
    public static class ExecucaoObserver
    {
        public static void Executar()
        {
            var user1 = new Observador("Benjamin");
            var user2 = new Observador("Paulo Pitte");
            var user3 = new Observador("José Paulo");

            var amazon = new PapelBovespa("Amazon", NextDecimal());
            var microsoft = new PapelBovespa("Microsoft", NextDecimal());
            
            amazon.Subscribe(user1);
            amazon.Subscribe(user2);

            microsoft.Subscribe(user2);
            microsoft.Subscribe(user3);

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Valor = NextDecimal();
                microsoft.Valor = NextDecimal();

                if (i == 1)
                {
                    amazon.UnSubscribe(user2);
                }
            }
        }

        public static decimal NextDecimal()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);
           return r / (decimal) 100000.00;
        }
    }
}