using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos infoplayer = new Calculos();

            //Sem argumentos
            System.Console.WriteLine( infoplayer.Calcular() );

            //Com 1 argumento int
            System.Console.WriteLine( infoplayer.Calcular(100) );

            //Com 2 argumentos int
            System.Console.WriteLine( infoplayer.Calcular(100, 40));

            //Com 2 argumentos string
            System.Console.WriteLine( infoplayer.Calcular("Chuck", "Norris"));

            //Com 3 argumentos int
            System.Console.WriteLine( infoplayer.Calcular(30, 50, 30));
        }
    }
}
