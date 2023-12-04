/*
 * W tym przykładzie mamy metodę o nazwie MultiplyByTwo,
 * która przyjmuje liczbę całkowitą (int) jako parametr wejściowy i ma parametr wyjściowy (out int result).
 * Metoda mnoży wartość liczbową przez 2 i przypisuje wynik do parametru wyjściowego result.
 *
 * W funkcji Main następuje wywołanie metody MultiplyByTwo,
 * gdzie przekazujemy wartość inputNumber i zmienną result jako parametr wyjściowy.
 * Po wykonaniu metody, zmienna result będzie miała przypisaną wartość wyniku operacji mnożenia,
 * która następnie zostanie wyświetlona na ekranie. Metoda z parametrem out pozwala na zwracanie więcej niż jednej wartości przez referencję.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp70
{
    public class OutVariablesExercise : ExerciseBase
    {
        public override void Run()
        {
            int inputNumber = 10;
            int result;

            // Wywołanie metody MultiplyByTwo z użyciem zmiennej wyjściowej
            MultiplyByTwo(inputNumber, out result);

            Console.WriteLine($"Wynik mnożenia: {result}");
        }

        void MultiplyByTwo(int number, out int result)
        {
            // Mnożenie liczby przez 2 i przypisanie wyniku do parametru wyjściowego
            result = number * 2;
        }
    }
}
