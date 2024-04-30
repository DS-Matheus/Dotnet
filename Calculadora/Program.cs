
namespace Calculadora
{
    class Programa
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("=====================================");
            Console.WriteLine(" Selecione a operação desejada:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("=====================================");

            short OperacaoEscolhida = short.Parse(Console.ReadLine());

            switch (OperacaoEscolhida)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static double lerPrimeiroValor()
        {
            Console.WriteLine("Digite o primeiro valor");
            double valor = Convert.ToDouble(Console.ReadLine());
            return valor;
        }

        static double lerSegundoValor()
        {
            Console.WriteLine("Digite o segundo valor");
            double valor = Convert.ToDouble(Console.ReadLine());
            return valor;
        }

        static void Soma()
        {
            Console.Clear();
            double valor1 = lerPrimeiroValor();
            double valor2 = lerSegundoValor();

            Console.WriteLine("");
            Console.WriteLine($"O resultado da soma é {valor1 + valor2}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            double valor1 = lerPrimeiroValor();
            double valor2 = lerSegundoValor();

            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é {valor1 - valor2}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            double valor1 = lerPrimeiroValor();
            double valor2 = lerSegundoValor();

            Console.WriteLine("");
            Console.WriteLine($"O resultado da divisão é {valor1 / valor2}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            double valor1 = lerPrimeiroValor();
            double valor2 = lerSegundoValor();

            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é {valor1 * valor2}");
            Console.ReadKey();
            Menu();
        }
    }
}