using System;
using System.Globalization;

namespace MaisVelho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Programa Mais Velho ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
            Pessoas p1, p2;
            p1 = new Pessoas();
            p2 = new Pessoas();
            Console.WriteLine("Dados da Primeira Pessoa : ");
            Console.Write("Nome  e Idade : ");
            string[] vet1 = Console.ReadLine().Split(',');
            p1.Nome = vet1[0];
            p1.idade = int.Parse(vet1[1]);
            Console.WriteLine("Dados da Segunda Pessoa : ");
            Console.Write("Nome : ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade : ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Mais Velhor : " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Mais Velhor : " + p2.Nome);
            }

            Funcionarios f1, f2;
            f1 = new Funcionarios();
            f2 = new Funcionarios();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Programa Média de Salário ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
            Console.WriteLine("Funcionario 1 :");
            Console.Write("Nome : ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário : ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario 2 : ");
            Console.Write("Nome : ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário : ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Média de Salario : " + media.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
