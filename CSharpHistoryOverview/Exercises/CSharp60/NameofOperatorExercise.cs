/*
 * W tym przykładzie nameof jest używany do pobrania nazw identyfikatorów: person, person.FirstName i person.GetFullName().
 * Można zauważyć, że nameof zapewnia bezpieczne odwoływanie się do identyfikatorów, co pomaga uniknąć literałów łańcuchowych,
 * które mogą być podatne na błędy w trakcie refaktoryzacji kodu lub zmiany struktury danych.
 * Dodatkowo, funkcja IsPropertyExist demonstruje użyteczność nameof poprzez sprawdzanie istnienia właściwości w klasie
 * na podstawie nazwy właściwości przekazanej jako argument.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp60
{
    public class NameofOperatorExercise : ExerciseBase
    {
        public override void Run()
        {
            // Definicja klasy z polami
            Person person = new Person { FirstName = "John", LastName = "Doe" };

            // Użycie operatora nameof do uzyskania nazwy właściwości i wyświetlenie komunikatu
            Console.WriteLine($"Zmienna: {nameof(person)}");
            Console.WriteLine($"Pole: {nameof(person.FirstName)}");
            Console.WriteLine($"Metoda: {nameof(person.GetFullName)}");

            // Sprawdzenie, czy właściwość istnieje z użyciem nameof
            if (IsPropertyExist(person, nameof(person.FirstName)))
            {
                Console.WriteLine("Właściwość 'FirstName' istnieje.");
            }
            else
            {
                Console.WriteLine("Właściwość 'FirstName' nie istnieje.");
            }
        }

        // Metoda sprawdzająca istnienie właściwości w klasie
        static bool IsPropertyExist(object obj, string propertyName)
        {
            var type = obj.GetType();
            return type.GetProperty(propertyName) != null;
        }
    }

    partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
