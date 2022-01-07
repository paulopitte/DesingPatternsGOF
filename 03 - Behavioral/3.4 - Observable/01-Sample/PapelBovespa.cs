namespace _01_Sample
{

    // Concrete Subject
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal preco)
            : base(simbolo, preco)
        {
        }
    }
}