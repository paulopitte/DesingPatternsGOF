﻿using _01_Sample.Concrete;
using System;
using static System.Console;

namespace _01_Sample
{

    /*
     * Permite a separação da contrução de um objeto complexo da sua representação final de forma que o mesmo processo de contrução posso criar diferentes representações.
     * dessa forma o processo de contrução do pardao build deve ser genérico.
     * 
     * 
     * podemos produzir diferentes tipos e representações de um objeto usando o mesmo código de contrução;
     * constroi um objeto complexo usando muitos objetos simples com uma abordagem passo a passo.
     * 
     * 
     * em um exemplo de processo de contrução genérico para um notebook.
     * 
     * temos os passos
     * ********************************************
     * 1 - Conecte a memória
     * 2 - Conecte o HD
     * 3 - Conecte a Bateria
     * 4 - Contecte o teclado
     * 5 - Contecte o mouse
     * ....
     * 10 - Embate o notebook em uma caixa.
     * *******************************************
     * usando esse processo, podemos ter como resultado variações de um mesmo produto complexo.
     * 
     * note com 8GB 500MB, tela fullHD
     * note com 16GB 1T, tela wide
     * note com 32GB 2T, tela superwide
     * 
     * ***************************************************
     * 
     * "Director" ou gerente - COntrói um objeto utilizando a interface do Builder(Controla o acesso de criação).
     * 
     * "Builder" - Especifica uma interface abstrata para criar as partes do objeto Product.
     * 
     * "ConcreteBuilder" - Implementa uma forma de contruir o produto, (parte por parte) 
     * seguindo a abstração Builder e guarda a representação do objeto produto fornecendo um método para recuperá-lo, após sua contrução.(GetResult)
     * 
     * "Product" - Representa o objeto complexo em contrução. inclui classes que define as partes constituintes, incluindo interfaces para montar as partes no resultado final.
     * 
     * OBS - 
     * O AbstractFactory é usado para criar uma fábrica de fábricas,  
     * No AbstractFactory o consumidor invoca os médotos Factory para criar os objetos.
     * 
     * 
     * No Builder a classe Builder cria um objeto dependendo das informações que recebe mas o processo de criação é abstraído.
     * 
     * O AbstractFactory  - é útil quando precisamos criar objetos usando vários métodos factory.
     * O Builder - é útil quando precisamos criar um objeto complexo passo a passo.
     * 
     * 
     * 
     * o padrão Factory pode ser visto como uma forma simplificada do padrão "Builder".
     * 
     * 
     * 
     * A diferenaça é bem sensivel,
     * pensando em pizza.....,
     * para "Fazer uma pizza" temos diferentes coberturas para cada tipo ou "sabor" exemplo - Mussarela - Calabresa - Marguerita, etc...
     * 
     * para escolha de uma pizza ou seja o sabor podemos usar o Factory
     * 
     * já para os igredientes ou seja como montar (Fazer) uma pizza exemplo de Baiana podemos usar o builder.
     * cobertura - tomate, queijo, cebola, ovos,etc....
     * 
     * podemos concluir que o bulder podemos encapsular toda complexidade de negocio para um determinado produto. simples assim...
     * */
     class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" ****** Builder Sample 01 *******");
            WriteLine("*************************************");
            WriteLine();
            // instancia o Director
            var factor = new Factor();

            // instancia do concreteBuilder
            var notebookBuilder_Dell = new Notebook_DELL_Builder();

            //cria objetos conforme a especificação do produto no builder 
            factor.Build(notebookBuilder_Dell);


            WriteLine("*************************************");
            WriteLine();
            var notebookBuilder_HP = new Notebook_HP_Builder();
            factor.Build(notebookBuilder_HP);



            ReadKey();

        }
    }
}
