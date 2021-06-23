using System;
using Humanizer;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio();

            principal();
        }

        static void inicio()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------");
            Console.WriteLine("|Idade do Usuário|");
            Console.WriteLine("------------------");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("--> ");
            Console.ResetColor();

            Console.Write("Exibição da sua data de nascimento no formato de data longa. ");
            Console.WriteLine("Exibição também da data do seu aniversário de 18 anos.");
            Console.WriteLine();

        }

        static void principal()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("|");
            Console.ResetColor();
            Console.Write("Digite o dia do seu nascimento (DD): ");
            int dia = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("|");
            Console.ResetColor();
            Console.Write("Digite o mês do seu nascimento (MM): ");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("|");
            Console.ResetColor();
            Console.Write("Digite o ano do seu nascimento (AAAA): ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (dia < 1 || dia > 31)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Atenção!! O dia inserido não é válido.");
                Console.ResetColor();
            }

            if (mes < 1 || mes > 12)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Atenção!! O mês inserido não é válido.");
                Console.ResetColor();
            }

            if (ano < 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Atenção!! O ano inserido não é válido.");
                Console.ResetColor();
            }

            DateTime dataDeNascimento = new DateTime(ano, mes, dia);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("- ");
            Console.ResetColor();
            Console.Write("Você nasceu em uma ");
            Console.WriteLine(dataDeNascimento.ToLongDateString());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("- ");
            Console.ResetColor();
            Console.Write("Aniversário de 18 anos será/foi em ");
            Console.WriteLine(dataDeNascimento.AddYears(18));
        }
    }
}
