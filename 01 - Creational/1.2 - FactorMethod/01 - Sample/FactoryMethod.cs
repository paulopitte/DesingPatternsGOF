

namespace _01___Sample
{
    using Personagens;

    public class FactoryMethod
    {
        public IPersonagem Escolher_Personagem(string personagem)
        {
            return personagem switch
            {
                "SuperMario" => new SuperMario(),
                "SubZero" => new SubZero(),
                "PicaPau" => new PicaPau(),
                "Jaspion" => new Jaspion(),
                _ => null,
            };
        }
    }
}
