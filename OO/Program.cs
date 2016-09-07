using OO.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = new PessoaSemEncapsulamento();
            pessoa1.Nome = "A";
            pessoa1.DataNascimento = DateTime.Now.AddDays(7);

            Console.WriteLine("-------------------");
            Console.WriteLine("Pessoa 1");
            Console.WriteLine(string.Concat("Nome: ", pessoa1.Nome));
            Console.WriteLine(string.Concat("Data de nascimento: ", pessoa1.DataNascimento));
            Console.WriteLine("-------------------");

            var pessoa2 = new PessoaComEncapsulamento();

            Console.WriteLine("-------------------");
            Console.WriteLine("Pessoa 2");

            try
            {
                pessoa2.AtribuirNome("A");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(string.Concat("Erro: ", ex.Message));
            }

            pessoa2.AtribuirNome("José");


            try
            {
                pessoa2.AtribuirDataNascimento(DateTime.Now.AddDays(1));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(string.Concat("Erro: ", ex.Message));
            }

            pessoa2.AtribuirDataNascimento(DateTime.Now.AddYears(-10));

            Console.WriteLine(string.Concat("Nome: ", pessoa2.Nome));
            Console.WriteLine(string.Concat("Data de nascimento: ", pessoa2.DataNascimento));
            Console.WriteLine("-------------------");

            Console.ReadKey();
            
        }
    }
}
