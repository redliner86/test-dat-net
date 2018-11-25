using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y = a * (x * x) + b  * y + c");
            Console.Write("podaj wartośc a = ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj wartośc b = ");
            var b = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj wartośc c = ");
            var c = Convert.ToDouble(Console.ReadLine());

            Calculate(a, b, c);

            Console.WriteLine("Brawo! Czwarte zadanie zrobione :)");
            Console.WriteLine("Naciśnij jakikolwiek klawisz aby zakończyć...");
            Console.ReadKey();
        }

        private static void Calculate(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;

            if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("x = " + x1);
            }
            else
            {
                if (delta > 0)
                {
                    x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("x1 = " + x1 + "; x2 = " + x2);
                }
                else
                {
                    Console.WriteLine("Brak miejsc zerowych");
                }
            }                

            // napisz w tym miejscu obliczanie rozwiązań (miejsc zerowych)
            // funkcji kwadratowej i wypisanie ich na ekran
            //
            // jeśli nie pamiętasz jak to się liczy to tutaj jest ściąga
            // http://www.matematykam.pl/miejsca_zerowe_funkcji_kwadratowej.html
            //
            // pamiętaj, że trzeba obsłużyć trzy przypadki:
            // - brak miejsc zerowych: wtedy wyświetl taki komunikat
            // - jedno miejsce zerowe: wtedy wyświetl komunikat x = ...
            // - dwa miejsca zerowe: wtedy wyświetl komunikat x1 = ... x2 = ...
            //
            // postaraj się napisac to samodzielnie a nie googlując implementacji
            //
            // powodzenia :)
        }
    }
}