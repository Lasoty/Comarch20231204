/*
 * W tym przykładzie zdefiniowano rekord Point, który przechowuje współrzędne X i Y.
 * Rekordy są nowym typem danych w C# 9, zaprojektowanym głównie do przechowywania danych niemutowalnych.
 *
 * Point jest deklarowany jako rekord za pomocą skróconej składni deklaracji rekordu, która automatycznie generuje wiele funkcji,
 * takich jak metody Equals, GetHashCode, ToString, With, Deconstruct itd.
 *
 * point1 jest tworzony jako obiekt rekordu Point z wartościami X=3 i Y=5.
 *
 * Za pomocą operatora with tworzony jest nowy obiekt rekordu point2, który jest kopią point1, ale z zaktualizowanym polem Y=8.
 *
 * Porównanie point1 i point2 za pomocą operatora równości == zwraca False, ponieważ są to różne obiekty rekordów.
 *
 * Destrukturyzacja rekordu Point umożliwia wyodrębnienie jego pól do zmiennych x i y.
 *
 * Rekordy w C# 9 ułatwiają definiowanie niemutowalnych struktur danych, a ich składnia jest bardziej zwięzła niż tradycyjne klasy.
 * Wprowadzają one wiele nowych możliwości do obsługi danych w sposób bardziej funkcjonalny i bezpieczny.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp9
{
    public class RecordsExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzenie obiektu rekordu Person
            Person person1 = new Person("John", "Doe", 30);

            // Wyświetlanie informacji o osobie
            Console.WriteLine($"Person 1: {person1.FirstName} {person1.LastName}, Age: {person1.Age}");

            // Zmiana wartości jednego z pól rekordu za pomocą operatora "with"
            Person person2 = person1 with { Age = 35 };

            // Wyświetlanie informacji o zaktualizowanej osobie
            Console.WriteLine($"Person 2: {person2.FirstName} {person2.LastName}, Age: {person2.Age}");

            // Porównanie dwóch rekordów
            Console.WriteLine($"person1 == person2: {person1 == person2}"); // Powinno zwrócić "False"

            // Destrukturyzacja rekordu Person
            var (firstName, lastName, age) = person1;
            Console.WriteLine($"Destructured Person 1: {firstName} {lastName}, Age: {age}");

            // Próba modyfikacji pola "Age" - niemożliwe, ponieważ rekordy są niemutowalne (immutable)
            // person1.Age = 40; // To spowoduje błąd kompilacji, ponieważ pola rekordu są tylko do odczytu (readonly)

        }
    }

    // Definicja rekordu Person
    record Person(string FirstName, string LastName, int Age);
}
