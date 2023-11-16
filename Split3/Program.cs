using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Informe seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casas: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe seu ultimo nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            int b = int.Parse(vet[1]);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine("Os dados informados foram: ");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Número de quartos na casa: " + n1);
            Console.WriteLine("Preço do produto informado: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Ultimo nome: " + a);
            Console.WriteLine("Idade: " + b);
            Console.WriteLine("Altura: " + c.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
