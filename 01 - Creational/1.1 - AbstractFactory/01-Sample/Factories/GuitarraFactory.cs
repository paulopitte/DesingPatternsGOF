namespace _01_Sample.Factories
{
    using Domain.Entities.Guitarras;
    using Domain.Base;
    using Domain.ValueObj;
    using FactoryMethod;
    using System;

    public sealed class GuitarraFactory : IInstrumentoFactoryMethod
    {
        public InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType)
        {
            //Conversao -> DownCast
            var guitarraType = (GuitarraType)instrumentoFactoryType;

            return guitarraType switch
            {
                GuitarraType.IbanezGRG250 => new GuitarraIbanezGRG250(),
                GuitarraType.IbanezEVO => new GuitarraEVO(),
                GuitarraType.TagimaE1 => new GuitarraE1 { },
                GuitarraType.TagimaJA1 => new GuitarraJA1 { },
                GuitarraType.JacksonJ22 => new GuitarraJacksonJ22(),
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}
