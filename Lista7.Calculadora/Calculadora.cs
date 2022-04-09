﻿using System;

namespace Lista7
{
    class Program
    {
        static void Main(string[] args)
        {
              Calculadora();
        }

        public static void Calculadora()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Digite 'Ligar' para iniciar a conta");
            string ligar = Console.ReadLine();


            while (ligar.ToUpper() == "LIGAR")
            {

                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o operador: ");
                string operador = Console.ReadLine();

                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                switch (operador)
                {
                    case "+":
                        Console.WriteLine("Resultado: " + somar(num1, num2));
                        break;
                    case "-":
                        Console.WriteLine("Resultado: " + subtrair(num1, num2));
                        break;
                    case "*":
                        Console.WriteLine("Resultado: " + multiplicar(num1, num2));
                        break;
                    case "/":
                        Console.WriteLine("Resultado: " + dividir(num1, num2));
                        break;
                }

                Console.WriteLine("Nova operação:\nOu digite desligar ");
                string desligar = Console.ReadLine();

                if (desligar.ToUpper() == "DESLIGAR")
                {
                    break;
                }
            }
        }
        public static string somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
        public static string subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        public static string multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        public static string dividir(int num1, int num2)
        {
            if (valorDividendoMenorOuIgualAZero(num2))
            {
                return "Não é possivel dividir por zero ou menor que zero";
            }
            return (num1 / num2).ToString();

            bool valorDividendoMenorOuIgualAZero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
