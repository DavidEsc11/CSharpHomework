using System;

namespace CSharpHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n===== MENÚ DE EJERCICIOS =====");
                Console.WriteLine("1. Positive Power");
                Console.WriteLine("2. Double or Triple");
                Console.WriteLine("3. Root or Square");
                Console.WriteLine("4. Circle Perimeter");
                Console.WriteLine("5. Midweek Day");
                Console.WriteLine("6. Tax Calculator");
                Console.WriteLine("7. Remainder Finder");
                Console.WriteLine("8. Sum of Evens");
                Console.WriteLine("9. Fraction Difference");
                Console.WriteLine("10. String Length");
                Console.WriteLine("11. Average of Four");
                Console.WriteLine("12. Smallest of Five");
                Console.WriteLine("13. Vowel Counter");
                Console.WriteLine("14. Factorial Finder");
                Console.WriteLine("15. InRange Validator");
                Console.WriteLine("0. Salir");
                Console.Write("Elige un ejercicio: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": PositivePower(); break;
                    case "2": DoubleOrTriple(); break;
                    case "3": RootOrSquare(); break;
                    case "4": CirclePerimeter(); break;
                    case "5": MidweekDay(); break;
                    case "6": TaxCalculator(); break;
                    case "7": RemainderFinder(); break;
                    case "8": SumOfEvens(); break;
                    case "9": FractionDifference(); break;
                    case "10": StringLength(); break;
                    case "11": AverageOfFour(); break;
                    case "12": SmallestOfFive(); break;
                    case "13": VowelCounter(); break;
                    case "14": FactorialFinder(); break;
                    case "15": InRangeValidator(); break;
                    case "0": salir = true; break;
                    default: Console.WriteLine("Opción inválida."); break;
                }
            }
        }

        // 1. Positive Power
        static void PositivePower()
        {
            Console.Write("Ingresa un número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine($"Resultado: {numero * numero}");
            else if (numero < 0)
                Console.WriteLine("Número negativo.");
            else
                Console.WriteLine("Resultado: 0");
        }

        // 2. Double or Triple
        static void DoubleOrTriple()
        {
            Console.Write("Primer número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine($"Resultado: {a * 2}");
            else
                Console.WriteLine($"Resultado: {b * 3}");
        }

        // 3. Root or Square
        static void RootOrSquare()
        {
            Console.Write("Ingresa un número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero >= 0)
                Console.WriteLine($"Resultado: {Math.Sqrt(numero)}");
            else
                Console.WriteLine($"Resultado: {numero * numero}");
        }

        // 4. Circle Perimeter
        static void CirclePerimeter()
        {
            Console.Write("Ingresa el radio: ");
            double radio = double.Parse(Console.ReadLine());
            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine($"Resultado: {perimetro:0.00}");
        }

        // 5. Midweek Day
        static void MidweekDay()
        {
            Console.Write("Ingresa un número entre 1 y 7: ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                default: Console.WriteLine("Número fuera del rango laboral."); break;
            }
        }

        // 6. Tax Calculator
        static void TaxCalculator()
        {
            Console.Write("Ingresa tu salario anual: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario > 12000)
            {
                double impuesto = (salario - 12000) * 0.15;
                Console.WriteLine($"Resultado: {impuesto:0}");
            }
            else
            {
                Console.WriteLine("No debe impuestos.");
            }
        }

        // 7. Remainder Finder
        static void RemainderFinder()
        {
            Console.Write("Primer número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {a % b}");
        }

        // 8. Sum of Evens
        static void SumOfEvens()
        {
            int suma = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                    suma += i;
            }
            Console.WriteLine($"Resultado: {suma}");
        }

        // 9. Fraction Difference
        static void FractionDifference()
        {
            Console.Write("Numerador de la primera fracción: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Denominador de la primera fracción: ");
            int den1 = int.Parse(Console.ReadLine());
            Console.Write("Numerador de la segunda fracción: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Denominador de la segunda fracción: ");
            int den2 = int.Parse(Console.ReadLine());

            int numResultado = num1 * den2 - num2 * den1;
            int denResultado = den1 * den2;

            int mcd = MCD(Math.Abs(numResultado), Math.Abs(denResultado));
            if (mcd != 0)
            {
                numResultado /= mcd;
                denResultado /= mcd;
            }

            if (numResultado == 0)
                Console.WriteLine("Resultado: 0");
            else
                Console.WriteLine($"Resultado: {numResultado}/{denResultado}");
        }

        static int MCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // 10. String Length
        static void StringLength()
        {
            Console.Write("Ingresa una palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine($"Resultado: {palabra.Length}");
        }

        // 11. Average of Four
        static void AverageOfFour()
        {
            double suma = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Número {i}: ");
                suma += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Resultado: {suma / 4}");
        }

        // 12. Smallest of Five
        static void SmallestOfFive()
        {
            double menor = double.MaxValue;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Número {i}: ");
                double numero = double.Parse(Console.ReadLine());
                if (numero < menor)
                    menor = numero;
            }
            Console.WriteLine($"Resultado: {menor}");
        }

        // 13. Vowel Counter
        static void VowelCounter()
        {
            Console.Write("Ingresa una palabra: ");
            string palabra = Console.ReadLine().ToLower();
            int contador = 0;

            foreach (char letra in palabra)
            {
                if ("aeiou".IndexOf(letra) >= 0)
                    contador++;
            }

            Console.WriteLine($"Resultado: {contador}");
        }

        // 14. Factorial Finder
        static void FactorialFinder()
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            long factorial = 1;

            for (int i = 1; i <= numero; i++)
                factorial *= i;

            Console.WriteLine($"Resultado: {factorial}");
        }

        // 15. InRange Validator
        static void InRangeValidator()
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
                Console.WriteLine("Está en el rango.");
            else
                Console.WriteLine("Fuera del rango.");
        }
    }
}