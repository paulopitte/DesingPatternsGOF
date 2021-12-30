namespace _01_Sample.Factories
{
    using System;
    using Domain.Base;
    using Domain.Entities;
    using Domain.ValueObj;
    using FactoryMethod;

    public sealed class ContraBaixoFactory : IInstrumentoFactoryMethod
    {
        public InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType)
        {
            // DOWNCAST
            var contraBaixoType = (ContraBaixoType)instrumentoFactoryType;

            return contraBaixoType switch
            {
                ContraBaixoType.Fender => new ContraBaixoFender { },
                ContraBaixoType.MusicMan => new ContraBaixoMusicMan { },
                _ => throw new ArgumentOutOfRangeException(nameof(ContraBaixoType), contraBaixoType, null)
            };
        }
    }
}
