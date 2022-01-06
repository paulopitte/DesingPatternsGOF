using System;

namespace _01_Sample
{
    public class PersonagemC : Manipulador
    {
        public override void Convoca(int quantidadePoder)
        {
            if (quantidadePoder >= 20 && quantidadePoder < 30)
                Console.WriteLine("{0} convocado para uma força de poder de {1}", this.GetType().Name, quantidadePoder);
            else
                sucessor.Convoca(quantidadePoder);
        }
    }
}
