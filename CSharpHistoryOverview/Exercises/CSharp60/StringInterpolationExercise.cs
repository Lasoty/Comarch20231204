/*
 * W tym przykładzie zmienna message zawiera interpolowany napis, w którym wykorzystuje się zmienne name i age.
 * Interpolacja napisów w C# 6 jest realizowana poprzez umieszczenie wyrażenia w nawiasach klamrowych {}
 * wewnątrz napisu rozpoczynającego się od znaku $.
 * Wartości zmiennych lub wyrażeń umieszczonych wewnątrz nawiasów klamrowych zostaną automatycznie wstawione do finalnego napisu.
 *
 * Przykład ten pokazuje, jak interpolacja napisów może być przydatna do dynamicznego tworzenia komunikatów
 * lub napisów zawierających zmienne i wyrażenia w bardziej czytelny sposób niż konkatenacja tradycyjnych łańcuchów znaków.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp60
{
    public class StringInterpolationExercise : ExerciseBase
    {
        public override void Run()
        {
            string name = "John";
            int age = 30;

            // Wykorzystanie interpolacji napisów
            string message = $"Witaj, nazywam się {name} i mam {age} lat.";

            Console.WriteLine(message);
        }
    }
}
