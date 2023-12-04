/*
 * W tym przykładzie używamy inicjalizatorów automatycznie implementowanych właściwości wprowadzonych w C# 6.
 * Każda właściwość (Imie, Nazwisko, Wiek) ma przypisaną wartość domyślną bezpośrednio w deklaracji właściwości.
 *
 * Następnie tworzymy obiekt klasy Osoba i wyświetlamy informacje o tej osobie,
 * korzystając z wartości domyślnych przypisanych do właściwości.
 *
 * Inicjalizatory automatycznie implementowanych właściwości w C# 6
 * pozwalają na bardziej zwięzłe inicjowanie właściwości bez potrzeby pisania dodatkowego kodu w konstruktorze.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp60
{
    public class PropertiesInitializatiorsExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzenie obiektu klasy Osoba z użyciem inicjalizatorów właściwości
            var osoba = new Osoba();

            // Wyświetlanie informacji o osobie
            Console.WriteLine("Informacje o osobie:");
            Console.WriteLine("Imię: " + osoba.Imie);
            Console.WriteLine("Nazwisko: " + osoba.Nazwisko);
            Console.WriteLine("Wiek: " + osoba.Wiek + " lat");
        }
    }

    class Osoba
    {
        // Automatycznie implementowane właściwości z inicjalizatorami
        public string Imie { get; set; } = "Jan";
        public string Nazwisko { get; set; } = "Kowalski";
        public int Wiek { get; set; } = 30;
    }
}
