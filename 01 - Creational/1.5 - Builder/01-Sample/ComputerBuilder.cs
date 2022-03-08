using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Sample
{
    // Builder
    abstract class ComputerBuilder
    {
        public abstract void BuilderOS();
        public abstract void DevicesBuilder();

        Computer computerType { get; }
    }
}
