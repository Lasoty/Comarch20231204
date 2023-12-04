/*
 * W tym przykładzie używamy "lambda discard parameter" oznaczonego symbolem podkreślenia _.
 * Ten symbol oznacza parametr, którego nie zamierzamy używać w ciele lambdy.
 * W naszym przypadku używamy drugiego parametru y, ale pierwszy parametr jest oznaczony jako discard _.
 *
 * Funkcja add jest reprezentowana przez lambdę, która dodaje dwa parametry.
 * Jednakże, wynik operacji dodawania zależy tylko od parametru y, dlatego używamy discard parameter _ dla pierwszego parametru.
 * Ostatecznie wywołanie add(5, 3) zignoruje pierwszy parametr i dodaje tylko 3 do 5, zwracając 8 jako wynik.
 *
 * To wykorzystanie discard parameter w lambdach jest przydatne, gdy potrzebujemy określić,
 * że parametr jest wymagany przez sygnaturę funkcji, ale nie będzie używany w ciele lambdy.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp9
{
    public class LambdaDiscardParametersExercise : ExerciseBase
    {
        public override void Run()
        {
            AnonymousMethodExercise();
            LambdasExercise();
        }

        private void AnonymousMethodExercise()
        {
            // Przykład wykorzystania discard parameter w metodzie anonimowej
            DisplayMessage showMessage = delegate (string _)
            {
                Console.WriteLine("Message: " + _);
            };

            // Wywołanie metody anonimowej z użyciem discard parameter
            showMessage("Hello, world!");
        }

        private void LambdasExercise()
        {
            // Przykład wykorzystania discard parameter w lambdzie
            Func<int, int, int> add = (_, y) => _ + y;

            // Wywołanie lambdy z użyciem discard parameter
            int result = add(5, 3);
            Console.WriteLine($"Result of addition: {result}");
        }

        delegate void DisplayMessage(string message);
    }
}
