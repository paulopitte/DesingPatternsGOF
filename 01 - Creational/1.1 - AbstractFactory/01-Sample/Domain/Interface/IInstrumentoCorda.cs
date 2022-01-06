namespace _01_Sample.Domain.Interface
{
    using Entities;
    using System.Collections.Generic;

    public interface IInstrumentoCorda
    {
        IList<Nota> ListarNotas();

        short ObterQuantidadeCordas();
    }
}
