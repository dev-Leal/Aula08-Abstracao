using System;

namespace Aula_08__Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito elo = new CartaoCredito();
            elo.limite = 1500f;

            System.Console.WriteLine("Quanto você deseja de acrescimo para limite no cartão?");
            float acrescimo = float.Parse(Console.ReadLine ());

            elo.AumentarLimite (acrescimo);
            System.Console.WriteLine("novo limite: R$ "+elo.limite);
        }
    }
}
