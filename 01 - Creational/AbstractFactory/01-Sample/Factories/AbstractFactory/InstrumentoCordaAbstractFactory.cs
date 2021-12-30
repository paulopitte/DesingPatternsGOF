namespace _01_Sample.Factories.AbstractFactory
{
    using Factories.FactoryMethod;
    using Domain.ValueObj;

    public abstract class InstrumentoCordaAbstractFactory
    {
        // Criador da Fabrica, static
        public static IInstrumentoFactoryMethod CriaFabrica(InstrumentoType instrumentoType)
        {
            return (InstrumentoType)instrumentoType switch
            {
                InstrumentoType.Violao => new ViolaoFactory(),
                InstrumentoType.Guitarra => new GuitarraFactory(),
                InstrumentoType.ContraBaixo => new ContraBaixoFactory(),
                _ => throw new ArgumentOutOfRangeException(nameof(instrumentoType), instrumentoType, null)
            };
        }
    }
}
