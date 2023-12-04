/*
 * W tym przykładzie Person person jest ustawiony na wartość null.
 * Wywołanie metody GetName() na obiekcie person zostało wykonane z wykorzystaniem operatora ?.,
 * który zapewnia bezpieczne wywołanie metody, nawet jeśli person jest null. Jeśli person nie jest null,
 * metoda GetName() zostanie wywołana i zwróci imię.
 * W przeciwnym razie, jeśli person jest null, to wyrażenie person?.GetName() zwróci null.
 *
 * Operator ?? służy do określenia wartości domyślnej, która ma zostać użyta,
 * jeśli wynik wyrażenia po lewej stronie jest null. W tym przypadku, jeśli name jest null,
 * zostanie wyświetlony komunikat "Brak imienia".
 *
 * Ten przykład ilustruje, jak operator propagacji wartości null (?.) w C# 6 umożliwia wykonywanie operacji na obiektach,
 * które mogą być null, bez potrzeby ręcznego sprawdzania nulli za pomocą warunków if.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp60
{
    public class NullPropagationExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzenie obiektu Person, który może mieć null-ową wartość
            Person person = null;

            // Wywołanie metody na obiekcie, który może być null
            string name = person?.GetName();

            // Wyświetlenie rezultatu operacji, z uwzględnieniem wartości null
            Console.WriteLine($"Imię: {name ?? "Brak imienia"}");
        }
    }

    partial class Person
    {
        public string GetName()
        {
            return "John";
        }
    }
}
