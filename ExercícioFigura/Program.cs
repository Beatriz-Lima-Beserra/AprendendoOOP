using ExercícioFigura.src;
using System;

namespace ExercícioFigura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Garrafas da Catarina:");

            Garrafa barbie = new Garrafa("Barbie","Rosa", "Pequena", "Redonda");
            Garrafa ironman = new Garrafa("Iron Man", "Vermelho", "Grande", "Quadrada");
            Garrafa spiderman = new Garrafa("Spider Man","Azul", "Grande", "Redonda");
            Garrafa polly = new Garrafa("Polly","Laranja", "Grande", "Rendonda");



            Console.WriteLine(barbie.Tostring());
            Console.WriteLine(ironman.Tostring());
            Console.WriteLine(spiderman.Tostring());
            Console.WriteLine(polly.Tostring());







        }
    }
}
