using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWord
{
    class Calculator
    {
        private void Line(int i, string s)
        {
            for (int j = 0; j < i; j++)
            {
                s = s != null ? s : "=";
                Console.Write(s);
            }
        }

        private void Sum(int i, int j)
        {
            Console.Clear();
            this.Line(80, null);
            Console.WriteLine("Resultado: " + i + " + " + j + " = " + (i + j));
        }

        private void Sub(int i, int j)
        {
            Console.Clear();
            this.Line(80, null);
            Console.WriteLine("Resultado: " + i + " - " + j + " = " + (i - j));
        }

        private void Mult(int i, int j)
        {
            Console.Clear();
            this.Line(80, null);
            Console.WriteLine("Resultado: " + i + " * " + j + " = " + (i * j));
        }

        private void Div(int i, int j)
        {
            Console.Clear();
            this.Line(80, null);
            Console.WriteLine("Resultado: " + i + " / " + j + " = " + (i / j));
        }


        private int Menu()
        {
            int opcao;
            string[] opcoes = { "Soma", "Subtracao", "Multiplicacao", "Divisao" };

            this.Line(80, null);
            for (var i = 0; i < opcoes.Length; i++)
            {
                Console.WriteLine("[ " + (i + 1) + " ] " + opcoes[i]);
            }

            this.Line(80, null);

            Console.Write("Digite uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            return opcao;
        }

        static void Main(string[] args)
        {
            int opcao;
            int num1;
            int num2;

            Calculator calc = new Calculator();

            calc.Line(80, null);
            Console.WriteLine("Digite o primeiro numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            Console.Clear();

            opcao = calc.Menu();
            switch (opcao)
            {
                case 1:
                    calc.Sum(num1, num2);
                    break;
                case 2:
                    calc.Sub(num1, num2);
                    break;
                case 3:
                    calc.Mult(num1, num2);
                    break;
                case 4:
                    calc.Div(num1, num2);
                    break;
            }
        }
    }
}
