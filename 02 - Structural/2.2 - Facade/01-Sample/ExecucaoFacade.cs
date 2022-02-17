using System;
using System.Collections.Generic;

namespace _01_Sample
{
    public class ExecucaoFacade
    {
        /*
         * A IDEIA DO "FECADE" É TER UMA UNICA CLASS QUE SERVER COMO UM SISTEMA DE UMA PARTE DA APLICAÇÃO, 
         * OU SEJA ELA É REPONSAVEL EM (INSTANCIAR, CONSUMIR, INTERPRETAR E ADAPTAR) OS SUBSISTEMAS REALIZANDO UMA TRADUÇÃO PARA AS CLASSES CLIENTE.
         * 
         */
        public static void Executar()
        {
            var produtos = new List<Produto>
            {
                new Produto{Nome = "Tenis Adidas", Valor = new Random().Next(500)},
                new Produto{Nome = "Camisa Boliche", Valor = new Random().Next(500)},
                new Produto{Nome = "Raquete Tenis", Valor = new Random().Next(500)}
            };

            Pedido pedido = new ()
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            Pagamento pagamento = new ()
            {
                CartaoCredito = "5555 2222 5555 9999"
            };

            // TODO: Resolver com DI
            var pagamentoService = new PagamentoCartaoCreditoService(
                                     new PagamentoCartaoCreditoFacade(
                                        new PayPalGateway(), 
                                            new ConfigurationManager()));

            var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);

            Console.WriteLine(pagamentoResult.Status);
        }
    }

}