/*
 * W tym przykładzie tworzymy typ anonimowy poprzez użycie słowa kluczowego var i inicjalizujemy go obiektem,
 * który zawiera trzy właściwości: Imie, Nazwisko i Wiek.
 * Następnie wyświetlamy informacje o osobie, korzystając z tych właściwości.
 * Typ anonimowy jest używany tutaj do stworzenia obiektu bez konieczności wcześniejszego definiowania klasy.
 * Właściwości obiektu anonimowego są definiowane bezpośrednio w miejscu, gdzie jest on tworzony.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp20
{
    public class AnonymousTypesExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzenie i inicjalizacja obiektu typu anonimowego
            var osoba = new
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Wiek = 30
            };

            // Wyświetlanie informacji o osobie
            Console.WriteLine("Informacje o osobie:");
            Console.WriteLine("Imię: " + osoba.Imie);
            Console.WriteLine("Nazwisko: " + osoba.Nazwisko);
            Console.WriteLine("Wiek: " + osoba.Wiek + " lat");

            List<School> schools = new List<School>();

            //wypełnienie kolekcji

            var result = schools.Where(x => x.StudentsCount > 100)
                .Select(x => new
                {
                    x.StudentsCount,
                    x.Name,
                    Description = $"{x.Name} has {x.StudentsCount} students"
                });

            foreach (var item in result)
            {
                Console.WriteLine(item.Description);
            }
        }

        class School
        {
            public string Name { get; set; }

            public int StudentsCount { get; set; }

            //..
        }
    }
}
