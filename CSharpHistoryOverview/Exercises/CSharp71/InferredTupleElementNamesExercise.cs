/*
 * W tym przykładzie mamy metodę Divide, która przyjmuje dwie liczby całkowite: dividend i divisor.
 * Metoda ta dzieli dividend przez divisor i zwraca krotkę z nazwanymi elementami Quotient i Remainder.
 *
 * W funkcji Main, wynik działania metody Divide jest deklarowany jako var (quotient, remainder) = Divide(number, divisor);.
 * Dzięki temu quotient i remainder są odpowiednio nazwanymi elementami krotki zwracanej przez metodę Divide.
 *
 * Wnioskowanie nazwanych krotek w C# 7.1 umożliwia zwiększenie czytelności kodu poprzez użycie czytelnych nazw dla elementów krotek,
 * co ułatwia zrozumienie zwracanych wartości.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp71
{
    public class InferredTupleElementNamesExercise : ExerciseBase
    {
        public override void Run()
        {
            int number = 10;
            int divisor = 3;

            var (quotient, remainder) = Divide(number, divisor);

            Console.WriteLine($"Liczba: {number}, Dzielnik: {divisor}");
            Console.WriteLine($"Wynik dzielenia: Część całkowita = {quotient}, Reszta = {remainder}");

        }

        (int Quotient, int Remainder) Divide(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            return (quotient, remainder); // Zwracanie nazwanej krotki
        }
    }
}
