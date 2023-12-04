/*
 * W tym przykładzie mamy generyczną metodę DisplayType, która przyjmuje argument generyczny input.
 * Dzięki użyciu dopasowania do wzorca (is) z typami generycznymi, jesteśmy w stanie sprawdzić typ input
 * i wyświetlić odpowiedni komunikat w zależności od jego typu.
 *
 * Jeśli input jest liczbą całkowitą (int), zostanie wykonane dopasowanie do wzorca i wartość ta zostanie przypisana do zmiennej intValue,
 * co pozwoli na wyświetlenie informacji o typie jako liczba całkowita. Analogicznie, jeśli input jest typem string,
 * wartość ta zostanie przypisana do zmiennej stringValue, co umożliwi wyświetlenie informacji jako typu string.
 * W przypadku innych typów, zostanie wyświetlona nazwa ich typu przy pomocy metody GetType().Name.
 *
 * To połączenie dopasowania do wzorca z typami generycznymi pozwala na bardziej elastyczne
 * i czytelne operacje na różnych typach danych w generycznych funkcjach czy klasach.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp71
{
    public class PatternMatchingExercise : ExerciseBase
    {
        public override void Run()
        {
            DisplayType(10);            // Przykład dla liczby całkowitej
            DisplayType("Hello");       // Przykład dla typu string
            DisplayType(5.5);           // Przykład dla liczby zmiennoprzecinkowej
        }

        void DisplayType<T>(T input)
        {
            if (input is int intValue)
            {
                Console.WriteLine($"Typ int: {intValue}");
            }
            else if (input is string stringValue)
            {
                Console.WriteLine($"Typ string: {stringValue}");
            }
            else
            {
                Console.WriteLine($"Inny typ: {input.GetType().Name}");
            }
        }
    }
}
