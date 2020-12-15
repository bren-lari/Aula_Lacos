using System;

namespace QuartaAula_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
           Console.WriteLine("--- Bem vindo ao nosso sistema de calculador virtual ---\r\n");
           Console.Write("Deseja ver a tabuada de qual número? ");
           int respostaUsuario = int.Parse(Console.ReadLine());

           int tabuada;

           for(int contador = 0; contador <= 10; contador++){

           tabuada = respostaUsuario * contador;

           Console.WriteLine($"{respostaUsuario} * {contador} = {tabuada}");
           }

        }
    }
}
