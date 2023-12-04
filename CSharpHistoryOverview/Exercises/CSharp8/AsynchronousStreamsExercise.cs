/*
 * W tym przykładzie GenerateNumbersAsync jest metodą, która zwraca asynchroniczny strumień (IAsyncEnumerable<int>).
 * Metoda ta generuje liczby od 1 do 5 z opóźnieniem (await Task.Delay(500)), symulując operację czasochłonną lub asynchroniczną.
 * Wykorzystuje ona również słowo kluczowe yield return, aby zwrócić kolejne wartości w strumieniu.
 *
 * Główna metoda Main używa instrukcji await foreach do iteracji przez otrzymany asynchroniczny strumień liczb z GenerateNumbersAsync.
 * Dla każdej otrzymanej liczby wyświetla ją na konsoli i symuluje opóźnienie w przetwarzaniu przez wywołanie await Task.Delay(1000).
 *
 * Asynchroniczne strumienie są przydatne, gdy chcemy asynchronicznie generować dane lub przetwarzać je,
 * w tym przypadku pozwala to na łatwe generowanie i przetwarzanie danych w czasie rzeczywistym, gdy są one dostępne w miarę napływania.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp8
{
    public class AsynchronousStreamsExercise : ExerciseBase
    {
        public override async void Run()
        {
            await foreach (var number in GenerateNumbersAsync())
            {
                Console.WriteLine($"Received number: {number}");
                await Task.Delay(1000); // Emulacja opóźnienia w przetwarzaniu
            }
        }

        async IAsyncEnumerable<int> GenerateNumbersAsync()
        {
            for (int i = 1; i <= 5; i++)
            {
                await Task.Delay(500); // Emulacja opóźnienia w generowaniu liczby
                yield return i; // Zwraca kolejną liczbę w strumieniu
            }
        }
    }
}
