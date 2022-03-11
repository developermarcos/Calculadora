using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    internal class Calculadora
    {
        private static decimal _valor;
        public static decimal primeiroValor;
        public static decimal segundoValor;
        public static decimal Valor
        {
            get => _valor; 
            set => _valor = value; 
        }

        public static void Somar(decimal valor1, decimal valor2)
        {
            Valor = valor1 + valor2;
            Resultado("Soma",valor1, valor2, "+");
        }
        public static void Subtrair(decimal valor1, decimal valor2)
        {
            Valor = valor1 - valor2;
            Resultado("Subtração", valor1, valor2, "-");
        }
        public static void Multiplicar(decimal valor1, decimal valor2)
        {
            Valor = valor1 * valor2;
            Resultado("Multiplicação", valor1, valor2, "*");
        }
        public static void Dividir(decimal valor1, decimal valor2)
        {
            if(valor2 == 0)
            {
                Console.WriteLine("\nOperação abaixo não foi realizada");
                Console.WriteLine($"Divisão: {valor1} / {valor2} = (Divisão impossível)\n");
            }
            else
            {
                Valor = valor1 / valor2;
                Resultado("Divisão", valor1, valor2, "/");
            }  
        }
        private static void Resultado(string operacao, decimal valor1, decimal valor2, string operador)
        {
            Console.WriteLine($"{operacao}: {valor1} {operador} {valor2} = {Valor.ToString("N2")}");
        }
        public static void PopulaObjeto()
        {
            Somar(10.00m, 10.15m);
            Somar(10.00m, -10.15m);
            Subtrair(10.00m, -10.15m);
            Subtrair(10.00m, 10.15m);

            Multiplicar(0, -10.15m);
            Multiplicar(-10.00m, 10.15m);
            Multiplicar(-10.15m, 0);
            Multiplicar(10.15m, -10.00m);

            Dividir(0, -10.15m);
            Dividir(-10.00m, 10.15m);
            Dividir(-10.15m, 0);
            Dividir(10.15m, -10.00m);

        }
    }
}
