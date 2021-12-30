namespace _01_Sample.Domain.Base
{
    using Entities;
    using Interface;
    using ValueObj;
    public abstract class InstrumentoCordaBase : IInstrumentoCorda
    {
        public InstrumentoType InstrumentoType { get; set; }
        public string Modelo { get; set; }
        private short NumeroCordas { get; set; }

        protected InstrumentoCordaBase(string modelo, InstrumentoType instrumentoType, short numeroCordas)
        {
            InstrumentoType = instrumentoType;
            NumeroCordas = numeroCordas;
            Modelo = modelo;
        }

        // Neste uso um recuro da OOP, no caso repasso a responsabilidade da implementação do ListarNotas
        // inclusa no contrato na Interface para quem a implementar a abstrada base.
        public abstract IList<Nota> ListarNotas();

        public short ObterQuantidadeCordas() => NumeroCordas;

    }
}
