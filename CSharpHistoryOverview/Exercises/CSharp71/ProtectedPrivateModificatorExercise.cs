/*
 * W tym przykładzie mamy klasę bazową BaseClass, która ma pole private protected oraz metodę private protected.
 * Klasa DerivedClass dziedziczy po BaseClass i posiada publiczną metodę AccessPrivateProtected,
 * która może uzyskać dostęp do pól i metod o modyfikatorze private protected z klasy bazowej.
 *
 * Modyfikator private protected pozwala na dostęp do elementów klasy tylko dla klas dziedziczących z tej samej przestrzeni nazw,
 * co jest użyteczne, gdy chcemy udostępnić pewne elementy klasy bazowej tylko dla wybranych klas pochodnych w tym samym zestawie.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp71
{
    public class ProtectedPrivateModificatorExercise : ExerciseBase
    {
        public override void Run()
        {
            DerivedClass derived = new DerivedClass();
            derived.AccessPrivateProtected();
        }
    }

    // Klasa bazowa
    class BaseClass
    {
        private protected int privateProtectedField = 10;

        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Metoda dostępna tylko dla klas dziedziczących w tym samym zestawie.");
        }
    }

    // Klasa dziedzicząca z tej samej przestrzeni nazw
    class DerivedClass : BaseClass
    {
        public void AccessPrivateProtected()
        {
            Console.WriteLine($"Pole private protected z klasy pochodnej: {privateProtectedField}");
            PrivateProtectedMethod();
        }
    }
}
