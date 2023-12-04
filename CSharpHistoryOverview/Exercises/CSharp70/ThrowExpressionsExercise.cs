/*
 * W tym przykładzie, zmienna age jest przypisywana do zmiennej message w oparciu o operator warunkowy ?:.
 * Jeśli wartość age jest większa lub równa 18, przypisywany jest napis "Osoba jest pełnoletnia.".
 * Jednakże, jeśli age jest mniejsze niż 18, wówczas wyrażenie throw new ArgumentException("Osoba jest niepełnoletnia.")
 * zostanie wykonane, co spowoduje rzucenie wyjątku ArgumentException.
 *
 * Użycie wyrażeń throw pozwala na eleganckie rzucanie wyjątków w różnych kontekstach,
 * co jest szczególnie użyteczne w przypadku zwięzłego zarządzania błędami w bardziej złożonych strukturach kodu.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp70
{
    public class ThrowExpressionsExercise : ExerciseBase
    {
        public override void Run()
        {
            int age = 15;

            string message = (age >= 18) ?
                "Osoba jest pełnoletnia." :
                throw new ArgumentException("Osoba jest niepełnoletnia.");

            Console.WriteLine(message);
        }
    }
}
