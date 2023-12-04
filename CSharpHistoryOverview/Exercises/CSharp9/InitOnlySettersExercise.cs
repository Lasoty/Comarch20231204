/*
 * W tym przykładzie klasa Car ma właściwości Model i Year z inicjalizatorami typu init,
 * co oznacza, że mogą być one ustawione tylko podczas inicjalizacji obiektu lub w konstruktorze, a później nie mogą być zmienione.
 *
 * W głównej metodzie Main tworzony jest obiekt myCar klasy Car przy użyciu inicjalizatora typu init.
 * Następnie próba zmiany wartości pól poza konstruktorem spowoduje błąd kompilacji,
 * ponieważ init pozwala na ustawienie wartości tylko w czasie inicjalizacji.
 *
 * Setter typu init zapewnia mechanizm inicjalizacji właściwości, który chroni te właściwości przed zmianami po ich ustawieniu.
 * Ta cecha jest szczególnie przydatna, gdy chcemy zapewnić niemutowalność określonych pól w klasach i strukturach.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpHistoryOverview.Exercises;

namespace CSharpHistoryOverview.Exercises.CSharp9
{
    public class InitOnlySettersExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzenie obiektu klasy Car za pomocą inicjalizatora typu init
            Car myCar = new Car { Model = "Toyota", Year = 2022 };

            // Próba zmiany wartości pól za pomocą inicjalizacji typu init - niemożliwe poza konstruktorem
            // myCar.Model = "Honda"; // To spowoduje błąd kompilacji

            // Wyświetlanie informacji o samochodzie
            Console.WriteLine($"My car: Model {myCar.Model}, Year {myCar.Year}");
        }
    }

    class Car
    {
        public string Model { get; init; }
        public int Year { get; init; }
    }
}
