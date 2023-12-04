/*
 * W tym kodzie zdefiniowaliśmy klasę StringExtensions, która zawiera metodę rozszerzającą ToUpperCase.
 * Metoda ta przyjmuje obiekt typu string i zwraca ten sam tekst, ale z zamienionymi literami na wielkie za pomocą metody ToUpper().
 * W metodzie Main tworzymy przykładowy tekst, a następnie wywołujemy metodę rozszerzającą ToUpperCase, aby przekształcić tekst na wielkie litery. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp20
{
    public class ExtensionMethodsExercise : ExerciseBase
    {
        public override void Run()
        {
            string text = "Przykład tekstu do zmiany";

            // Wywołanie metody rozszerzającej
            string upperCaseText = text.ToUpperCase();

            Console.WriteLine("Tekst przed zmianą: " + text);
            Console.WriteLine("Tekst po zmianie na wielkie litery: " + upperCaseText);

        }
    }

    // Klasa rozszerzeń dla typu string
    public static class StringExtensions
    {
        // Metoda rozszerzająca zamieniająca tekst na wielkie litery
        public static string ToUpperCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input.ToUpper();
        }
    }
}
