namespace _01_Sample
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}