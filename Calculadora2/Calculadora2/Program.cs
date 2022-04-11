using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    internal class Program
    {
        enum Menu { Soma=1, Subtracao=2, divisao=3, Multiplicao=4, Potencia=5, Raiz=6, Sair=7};
        static void Main(string[] args)
        {
            bool escolherSair = false;
            while (!escolherSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC");
                Console.WriteLine("1-Somar\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");
                //criando, captando,
                Menu opcoes = (Menu)int.Parse(Console.ReadLine()); //aqui
                Console.WriteLine(opcoes);

                switch (opcoes)
                {
                    case Menu.Sair:
                        escolherSair=true;
                        break;
                    case Menu.Soma:
                        Somar();
                        break;
                    case Menu.Subtracao:
                        Subtrair();
                        break;
                    case Menu.divisao:
                        Dividir();
                        break;
                    case Menu.Multiplicao:
                        Multiplicar();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                }

                //Console.ReadLine();
                Console.Clear();
            }
        }
        static void Somar()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            int result = n1 + n2;
            Console.WriteLine($"{n1} + {n2} = {result}");
            Console.WriteLine("Tecle Enter para reiniciar");
            Console.ReadLine();
        }
        static void Subtrair()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            int result = n1 - n2;
            Console.WriteLine($"{n1} - {n2} = {result}");
            Console.WriteLine("Tecle Enter para reiniciar");
            Console.ReadLine();
        }
        static void Dividir()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            double result = (double)n1 / (double)n2;
            Console.WriteLine($"{n1} / {n2} = {result}");
            Console.WriteLine("Tecle Enter para reiniciar");
            Console.ReadLine();
        }

        static void Multiplicar()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            int result = n1 * n2;
            Console.WriteLine($"{n1} * {n2} = {result}");
            Console.WriteLine("Tecle Enter para reiniciar");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Digita a base: ");
            int nbase = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            float result = (float)Math.Pow(nbase, expoente);
            Console.WriteLine($"{nbase} elevado a {expoente} = {result}");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            double result = (double)Math.Sqrt(n);
            Console.WriteLine($"raiz de {n} = {result}");
            Console.ReadLine();
        }
    }
}
