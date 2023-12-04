/*
 * W tym przykładzie mamy tablicę różnych wartości przechowywanych jako object.
 * W pętli foreach iterujemy przez te wartości i wywołujemy metodę EvaluateValue, która korzysta z switch z dopasowaniem do wzorca.
 *
 * Dzięki dopasowaniu do wzorca (case int intValue, case double doubleValue, itd.)
 * możemy precyzyjnie dopasować i obsłużyć różne typy danych oraz wykonywać odpowiednie operacje
 * w zależności od typu wartości przechowywanej w zmiennej value.
 *
 * Dopasowanie do wzorca w C# 7 jest potężnym narzędziem,
 * które ułatwia obsługę różnych typów danych i wzorców, co zwiększa czytelność kodu oraz pozwala na bardziej wyraźne
 * i przejrzyste obsługiwanie różnych przypadków danych.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp70
{
    public class PatternMatchingExercise71 : ExerciseBase
    {
        public override void Run()
        {
            object[] values = { 10, 15.5, "hello", true, null };

            foreach (var value in values)
            {
                EvaluateValue(value);
            }
        }

        void EvaluateValue(object value)
        {
            switch (value)
            {
                case int intValue:
                    Console.WriteLine($"Wartość całkowita: {intValue}");
                    break;
                case double doubleValue:
                    Console.WriteLine($"Wartość zmiennoprzecinkowa: {doubleValue}");
                    break;
                case string stringValue:
                    Console.WriteLine($"Napis: {stringValue}");
                    break;
                case bool boolValue:
                    Console.WriteLine($"Wartość logiczna: {boolValue}");
                    break;
                case null:
                    Console.WriteLine("Wartość null");
                    break;
                default:
                    Console.WriteLine("Nieznany typ");
                    break;
            }
        }
    }
}
