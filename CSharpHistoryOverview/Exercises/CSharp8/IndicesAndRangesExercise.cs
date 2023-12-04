/*
 * W tym przykładzie mamy tablicę daysOfWeek, która przechowuje dni tygodnia. Wykorzystujemy indeksy i zakresy, które zostały wprowadzone w C# 8.
 *
 * Uzyskiwanie pojedynczego elementu za pomocą indeksu: string thirdDay = daysOfWeek[2];
 * Uzyskiwanie elementów od końca tablicy za pomocą indeksu: string lastDay = daysOfWeek[^1];
 * Tworzenie nowego zakresu i pobieranie elementów tablicy: string[] workingDays = daysOfWeek[0..5];
 * Uzyskiwanie elementów tablicy za pomocą składni zakresów: daysOfWeek[..3] (pierwsze trzy dni), daysOfWeek[3..] (dni od indeksu 3 do końca tablicy).
 *
 * Indeksy i zakresy w C# 8 są przydatne do wygodnego manipulowania i wybierania elementów tablicy
 * oraz innych kolekcji danych przy użyciu bardziej czytelnej i zwięzłej składni.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp8
{
    public class IndicesAndRangesExercise : ExerciseBase
    {
        public override void Run()
        {
            string[] daysOfWeek = {
                "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday", "Sunday"
            };

            // Uzyskiwanie pojedynczego elementu za pomocą indeksu
            string thirdDay = daysOfWeek[2];
            Console.WriteLine($"Third day of the week: {thirdDay}");

            // Uzyskiwanie elementów od końca tablicy za pomocą indeksu
            string lastDay = daysOfWeek[^1];
            Console.WriteLine($"Last day of the week: {lastDay}");

            // Tworzenie nowego zakresu i pobieranie elementów tablicy
            string[] workingDays = daysOfWeek[0..5];
            Console.WriteLine("Working days:");
            foreach (var day in workingDays)
            {
                Console.WriteLine(day);
            }

            // Uzyskiwanie elementów tablicy za pomocą składni zakresów
            Console.WriteLine("\nFirst three days of the week:");
            foreach (var day in daysOfWeek[..3])
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("\nDays from index 3 to the end:");
            foreach (var day in daysOfWeek[3..])
            {
                Console.WriteLine(day);
            }
        }
    }
}
