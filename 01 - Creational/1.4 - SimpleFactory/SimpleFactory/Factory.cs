using System;

namespace SimpleFactory
{
    internal class Factory
    {
        // Coração do Pattern SimpleFactory
        public static AbstractClass Create(string name)
        {
            AbstractClass abstractClass;
            switch (name)
            {
                case "1":
                    abstractClass = new Implementation_1();
                    abstractClass.Run(name);
                    abstractClass.ToString();
                    break;
                case "2":
                    abstractClass = new Implementation_2();
                    abstractClass.Run(name);
                    abstractClass.ToString();
                    break;
                default:
                    throw new ApplicationException($"A Implementação concreta para {name} não foi existe.");
            }
            return abstractClass;
        }
    }
}
