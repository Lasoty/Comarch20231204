/*
 * W tym przykładzie klasa Data przechowuje dane w tablicy items i implementuje metodę GetEnumerator,
 * która zwraca enumerator tablicy. Dzięki temu możliwe jest używanie pętli foreach bezpośrednio na obiekcie klasy Data.
 *
 * Chociaż klasa Data nie implementuje interfejsu IEnumerable, to jednak dzięki istnieniu metody GetEnumerator,
 * możliwe jest używanie pętli foreach. Jest to możliwe dzięki nowej funkcji wprowadzonej w C# 9,
 * która pozwala na wykorzystanie metody GetEnumerator w celu obsługi pętli foreach nawet dla typów,
 * które nie implementują interfejsu IEnumerable bezpośrednio.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp9
{
    public class ExtensionGetEnumeratorSupportExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzenie obiektu klasy Data
            Data data = new Data();

            // Użycie foreach do iteracji przez obiekt klasy Data
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Klasa reprezentująca dane do iteracji
    class Data
    {
        private readonly string[] items = { "Apple", "Banana", "Orange" };

        // Metoda zwracająca enumerator
        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
