/*
 * W tym przykładzie tworzymy klasę EvenNumbers, która implementuje interfejs IEnumerable.
 * Ta klasa zawiera tablicę liczb całkowitych numbers i definiuje metodę GetEnumerator(), która zwraca IEnumerator.
 * Metoda GetEnumerator() zawiera pętlę foreach, która iteruje przez tablicę liczb i za pomocą yield return zwraca tylko parzyste liczby.
 * W funkcji Run tworzymy obiekt EvenNumbers z tablicą liczb od 1 do 10, a następnie używamy pętli foreach,
 * aby przeiterować przez parzyste liczby i wyświetlić je na konsoli.
 */

using System.Collections;

namespace CSharpHistoryOverview.Exercises.CSharp20
{
    public class IteratorExercise : ExerciseBase
    {
        public override void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            EvenNumbers evenNumbers = new EvenNumbers(numbers);

            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }

    class EvenNumbers : IEnumerable
    {
        private int[] numbers;

        public EvenNumbers(int[] numbers)
        {
            this.numbers = numbers;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
