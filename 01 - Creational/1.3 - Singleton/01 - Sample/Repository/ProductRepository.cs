using _01___Sample.Domain;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _01___Sample.Repository
{
    public sealed class ProductRepository
    {
        /*
         * Singleton
         * Padrão que garante a existência de apenas uma instância de um objeto em memória, mantendo um ponto único e global ao seu contexto.
         * */

        private readonly ICollection<Product> _products;
        private static ProductRepository _instance = null;
        private static readonly object SyncObj = new();

        // Garante o contrutor privado
        private ProductRepository() =>
            _products = new Collection<Product>();


        public static ProductRepository GetInstance()
        {
            if (_instance != null) return _instance;

            // Lock serve para controle de instancias concorrentes, garante o threadSafe o mesmo enfilera as requisições gerando um ponteiro de acesso;
            lock (SyncObj)
            {
                if (_instance == null)
                    _instance = new();
            }
            return _instance;
        }

        public ICollection<Product> GetAll() =>
            _instance._products;


        public void Insert(Product product) => 
            _instance._products.Add(product);


    }
}
