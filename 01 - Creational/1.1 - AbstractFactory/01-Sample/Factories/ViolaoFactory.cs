namespace _01_Sample.Factories
{
    using System;
    using Domain.Entities.Violoes;
    using Domain.Base;
    using Domain.ValueObj;
    using FactoryMethod;

    public sealed class ViolaoFactory : IInstrumentoFactoryMethod
    {
        public InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType)
        {
            var violaoType = (ViolaoType)instrumentoFactoryType;

            switch (violaoType)
            {
                case ViolaoType.Takamine1ER4:
                    {
                        return new ViolaoTakamine1ER4();
                    }

                case ViolaoType.TakamineStudio:
                    {
                        return new ViolaoTakamineStudio();
                    }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
