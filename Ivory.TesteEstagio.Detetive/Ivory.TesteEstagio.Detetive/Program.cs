using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Program
    {
        static void Main(string[] args)
        {
            var testemunha = new Testemunha();

            // Escreva seu c�digo aqui.

            Console.WriteLine("N�mero de Tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
            Console.ReadKey();
        }
    }
}
