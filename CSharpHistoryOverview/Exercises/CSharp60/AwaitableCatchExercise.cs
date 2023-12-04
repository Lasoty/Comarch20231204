/*
 * W tym przykładzie metoda Main jest oznaczona jako async i używa operatora await w sekcjach try, catch oraz finally.
 * Metoda DoSomethingAsync symuluje asynchroniczną operację, która kończy się rzuceniem wyjątku.
 *
 * W sekcji catch, metoda HandleExceptionAsync obsługuje wyjątek asynchronicznie,
 * a w sekcji finally metoda CleanupAsync wykonuje asynchroniczne czyszczenie zasobów niezależnie od tego, czy wystąpił błąd.
 *
 * Dzięki możliwości użycia await w sekcjach catch i finally w C# 6,
 * można łatwo wykonywać operacje asynchroniczne w obszarach obsługi wyjątków
 * oraz w sekcjach kodu wymagających wykonania, niezależnie od tego, czy wystąpił błąd.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp60
{
    public class AwaitableCatchExercise : ExerciseBase
    {
        public override async void Run()
        {
            try
            {
                await DoSomethingAsync();
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(ex);
            }
            finally
            {
                await CleanupAsync();
            }
        }

        static async Task DoSomethingAsync()
        {
            // Symulacja asynchronicznej operacji
            await Task.Delay(2000);
            throw new Exception("Błąd w DoSomethingAsync");
        }

        static async Task HandleExceptionAsync(Exception ex)
        {
            // Obsługa wyjątku asynchronicznie
            await Task.Delay(1000);
            Console.WriteLine($"Obsługa wyjątku: {ex.Message}");
        }

        static async Task CleanupAsync()
        {
            // Asynchroniczne czyszczenie po zakończeniu, bez względu na to, czy wystąpił błąd
            await Task.Delay(500);
            Console.WriteLine("Czyszczenie zasobów...");
        }
    }
}
