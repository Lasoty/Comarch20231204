/*
 * W tym przykładzie użyto ulepszeń w dopasowywaniu wzorców w C# 9, takich jak wzorce relacyjne (>=, <=, >) i wzorce logiczne (and).
 *
 * Metoda CheckNumber przyjmuje liczbę całkowitą i używa wzorców relacyjnych i logicznych do sprawdzenia różnych warunków liczbowych:
 * number is >= 0 and <= 10: Sprawdza, czy liczba jest większa lub równa 0 oraz mniejsza lub równa 10.
 * number is > 10: Sprawdza, czy liczba jest większa od 10.
 * Pozostałe przypadki obsługiwane są przez blok else.
 *
 * Wzorce relacyjne i logiczne wprowadzone w C# 9 pozwalają na bardziej czytelne i zwięzłe sprawdzanie wielu warunków jednocześnie,
 * co poprawia czytelność kodu i ułatwia pracę z warunkami logicznymi.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp9
{
    public class RelationalAndLogicalPatternsExercise : ExerciseBase
    {
        public override void Run()
        {
            CheckNumber(7);
            CheckNumber(15);
            CheckNumber(5);
            CheckNumber(10);
        }

        void CheckNumber(int number)
        {
            Console.WriteLine($"Checking number: {number}");

            // Wzorzec relacyjny sprawdzający, czy liczba jest mniejsza niż 10 lub równa 10
            if (number is >= 0 and <= 10)
            {
                Console.WriteLine("Number is between 0 and 10 (inclusive).");
            }
            else if (number is > 10)
            {
                Console.WriteLine("Number is greater than 10.");
            }
            else
            {
                Console.WriteLine("Number is negative.");
            }

            Console.WriteLine();
        }
    }
}
