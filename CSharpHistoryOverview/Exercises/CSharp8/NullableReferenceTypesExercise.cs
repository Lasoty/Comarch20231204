/*
 * W tym przykładzie zadeklarowano zmienną nullableString jako nullable reference type (string?),
 * która może przyjąć wartość null. Natomiast nonNullableString jest zmienną typu string,
 * której nie można przypisać wartości null bezpośrednio z powodu ustawionego typu na nieprzechodni.
 *
 * Typy referencyjne o wartościach null (nullable reference types) w C# 8 pozwalają na ścisłą kontrolę wartości null w kodzie,
 * co pomaga unikać niechcianych błędów związanych z odwoływaniem się do wartości null.
 * Wprowadzają one ostrzejsze zasady dotyczące zarządzania wartościami null w języku C#.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp8
{
    public class NullableReferenceTypesExercise : ExerciseBase
    {
        public override void Run()
        {
            string? nullableString = null;
            string nonNullableString = "Hello";

            // Próba przypisania wartości null do typu nieprzechodniego
            // nonNullableString = null; // To spowoduje błąd kompilacji CS8625

            // Porównanie wartości null w nullable reference types
            if (nullableString == null)
            {
                Console.WriteLine("nullableString ma wartość null.");
            }
            else
            {
                Console.WriteLine($"nullableString ma wartość: {nullableString}");
            }

            // Wywołanie metody z parametrem nullable reference type
            ProcessString(nullableString);
            ProcessString(nonNullableString);
        }

        void ProcessString(string? text)
        {
            if (text != null)
            {
                Console.WriteLine($"Przetwarzanie tekstu: {text}");
            }
            else
            {
                Console.WriteLine("Brak tekstu do przetworzenia.");
            }
        }
    }
}
