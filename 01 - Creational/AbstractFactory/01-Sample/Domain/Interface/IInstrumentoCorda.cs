namespace _01_Sample.Domain.Interface
{
    using Entities;
    public interface IInstrumentoCorda
    {
        IList<Nota> ListarNotas();

        short ObterQuantidadeCordas();
    }
}
