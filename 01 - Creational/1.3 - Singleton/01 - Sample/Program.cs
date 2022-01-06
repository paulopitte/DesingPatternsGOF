 
namespace _01___Sample
{
    using Domain;
    using Repository;
    using System;
    using System.Linq;

    class Program
    {

        // * Singleton
        //* Padrão que garante a existência de apenas uma instância de um objeto em memória, mantendo um ponto único e global ao seu contexto.
        private static void Main(string[] args)
        {
            var repo = ProductRepository.GetInstance();

            var list1 = repo.GetAll();

            repo.Insert(new Product("BR0001", "PRODUTO 1", 33.98M));
            repo.Insert(new Product("BR0002", "PRODUTO 2", 44.91M));
            repo.Insert(new Product("BR0003", "PRODUTO 3", 8419.10M));


            var list2 = repo.GetAll();
            var repo2 = ProductRepository.GetInstance();

            var list3 = repo2.GetAll();

            Console.WriteLine("listagem repo1");
            list1.ToList().ForEach(Print);

            Console.WriteLine("listagem repo2");
            list2.ToList().ForEach(Print);

            Console.WriteLine("listagem repo3");
            list3.ToList().ForEach(Print);

            Console.ReadKey();







 
            static void Print(Product product) =>
                Console.WriteLine(product.Title + " - " + product.Sku + " - " + product.Price + " ID: " + product.Id);

        }



    }
}
