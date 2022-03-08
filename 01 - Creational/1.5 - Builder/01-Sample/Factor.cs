using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Sample
{
    // Director - cara responsavel em controlar a criação e espeficicações do produto
     class Factor
    {
        public void Build(ComputerBuilder computerBuilder)
        {
            computerBuilder.DevicesBuilder();
            computerBuilder.BuilderOS();
        }
    }
}
