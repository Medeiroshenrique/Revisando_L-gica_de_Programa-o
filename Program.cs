using System;
using System.Globalization;
namespace Revisando
{
    class Program {
        static void Main() {
            Console.WriteLine("Entre com seu nome completo:");
            string Nome=Console.ReadLine();
            Console.WriteLine("Quantos quartos tem a sua casa?");
            int QuantosQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto:");
            float PrecoProduto=float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu Ultimo Nome, Idade e Altura (na mesma linha, separados por espaco)");
            string[] Ultimo_nomeIdadeAltura = Console.ReadLine().Split(' ');
            string UltimoNome = Ultimo_nomeIdadeAltura[0];
            int Idade = int.Parse(Ultimo_nomeIdadeAltura[1]);
            float Altura = float.Parse(Ultimo_nomeIdadeAltura[2]);
            Console.WriteLine(Nome);
            Console.WriteLine(QuantosQuartos);
            Console.WriteLine(PrecoProduto);    
            Console.WriteLine(UltimoNome);
            Console.WriteLine(Idade);
            Console.WriteLine(Altura);
            
            
        }
    }
}
