/*
 * W tym przykładzie funkcja CreatePerson tworzy krotkę zawierającą informacje o osobie (imię, nazwisko i wiek).
 * Następnie, w funkcji Main, dekonstruuje tę krotkę do zmiennych firstName, lastName i age
 * za pomocą składni (var (firstName, lastName, age) = person).
 * Dzięki temu można łatwo otrzymać dostęp do poszczególnych elementów krotki i wyświetlić je na konsoli.
 *
 * Dekonstrukcja krotek w C# 7 pozwala na wygodne wydobywanie danych z krotek oraz umożliwia zapisywanie wielu wartości
 * w jednym typie danych, co jest przydatne w wielu scenariuszach,
 * takich jak zwracanie wielu wyników z funkcji czy przechowywanie zestawu wartości powiązanych ze sobą.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp70
{
    public class TuplesAndDeconstructionExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzenie krotki zawierającej informacje o osobie
            var person = CreatePerson();

            // Dekonstrukcja krotki
            var (firstName, lastName, age) = person;

            // Wyświetlenie danych za pomocą dekonstrukcji krotki
            Console.WriteLine($"Imię: {firstName}");
            Console.WriteLine($"Nazwisko: {lastName}");
            Console.WriteLine($"Wiek: {age}");
        }

        (string, string, int) CreatePerson()
        {
            // Tworzenie i zwracanie krotki z danymi osoby
            return ("John", "Doe", 30);
        }
    }
}
