namespace _01_Sample
{
    // Observer
    public interface IObservador
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}