/*
 * W tym przykładzie funkcja ProcessData przetwarza dane i może rzucić wyjątki ArgumentException
 * dla nieprawidłowych wartości i InvalidOperationException dla wartości równych zero.
 *
 * W bloku catch używamy filtrów wyjątków (when), aby przechwycić wyjątek ArgumentException tylko wtedy,
 * gdy parametr ParamName jest równy "value". Drugi blok catch przechwytuje ogólny wyjątek Exception
 * i wywołuje funkcję LogException jako filtr, która zwraca true, aby umożliwić przechwycenie wyjątku i zalogowanie go.
 *
 * To podejście pozwala na bardziej elastyczne zarządzanie przechwytywaniem wyjątków,
 * co jest przydatne, gdy chcemy dokładniej kontrolować, które wyjątki przechwytujemy w zależności od określonych warunków.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp60
{
    public class ExceptionFiltersExercise : ExerciseBase
    {
        public override void Run()
        {
            try
            {
                // Wywołanie metody, która może rzucić wyjątek
                ProcessData(10);
                ProcessData(-5);
            }
            catch (ArgumentException ex) when (ex.ParamName == "value")
            {
                Console.WriteLine("Wyjątek ArgumentException: Nieprawidłowa wartość przekazana.");
            }
            catch (Exception ex) when (LogException(ex))
            {
                Console.WriteLine("Wyjątek ogólny przechwycony i zalogowany.");
            }
        }

        static void ProcessData(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Nieprawidłowa wartość przekazana.", nameof(value));
            }

            // Symulacja innego wyjątku
            if (value == 0)
            {
                throw new InvalidOperationException("Nie można przetworzyć danych.");
            }

            Console.WriteLine($"Przetworzono dane dla wartości: {value}");
        }

        bool LogException(Exception ex)
        {
            // Symulacja logowania wyjątku
            Console.WriteLine($"Zalogowano wyjątek: {ex.Message}");
            return true;
        }
    }
}
