using System;
using System.Collections.Generic;

namespace _01_Sample
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}