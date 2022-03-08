using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    internal class Implementation_1 : AbstractClass
    {
        public override void Run(string name)
            =>   this.Name = name;

        public override string ToString()
        {
            return $" Executando implementação de {base.Name}.";
        }
    }
}
