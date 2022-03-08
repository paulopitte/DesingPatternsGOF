using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    internal class Implementation_2 : AbstractClass
    {
        public override void Run(string name)
            => this.Name = name;

        public override string ToString()
            => $" Executando implementação de {base.Name} ...";
        
    }
}
