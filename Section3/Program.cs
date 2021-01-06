using System;

namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            //double preco = double.Parse(Console.ReadLine());
            //double desconto = 0.0;

            //if (preco > 100.0)
            //{
            //    desconto = preco * 0.1;
            //}

            //Console.WriteLine(desconto);

            //console.writeline("digite 3 numeros: ");
            //int n1 = int.parse(console.readline());
            //int n2 = int.parse(console.readline());
            //int n3 = int.parse(console.readline());

            //double resultado = Maior(n1, n2, n3);

            //Console.WriteLine("Maior = " + resultado);
            //**************************************************************************************
            //Console.Write("Digite um numero: ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //while (x >= 0.0)
            //{
            //    double raiz = Math.Sqrt(x);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.Write("Digite outro numero: ");

            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //Console.WriteLine("Numero negativo!");
            //**************************************************************************************
            Console.Write("Quantos numeros inteiros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor: #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }

        //static int Maior(int a, int b, int c)
        //{
        //    int m;
        //    if (a > b && a > c) m = a;
        //    else if (b > c) m = b;
        //    else m = c;

        //    return m;
        //}
    }
}
