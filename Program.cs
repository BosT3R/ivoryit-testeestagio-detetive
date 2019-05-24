using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Program
    {
        static void Main(string[] args)
        {
            var testemunha = new Testemunha();

            // Escreva seu código aqui.           

            int tCriminoso;
            
            var tstCriminoso = new Random();
            tCriminoso = tstCriminoso.Next(1, 8);

            //Laço de repetição para validar os parametros e testar os mesmos n vezes até encontrar a combinação correta
            while (true)
            {


                var criminoso = new Random();
                int Criminoso = criminoso.Next(1, 9);

                Thread.Sleep(50);

                var local = new Random();
                int Local = local.Next(1, 10);

                Thread.Sleep(50);

                var arma = new Random();
                int Arma = arma.Next(1, 7);

                int op = testemunha.Interrogar(Criminoso, Local, Arma);
                Console.WriteLine(op);
                Console.WriteLine("Total de tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
                if (op == 0)
                    break;
            }
            Console.WriteLine(testemunha.Interrogar(6, 4, 4));
            Console.WriteLine("Número de Tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
            Console.ReadKey();
        }
    }
}
