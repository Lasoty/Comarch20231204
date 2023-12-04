/*
 * W tym przykładzie mamy interfejs ILogger z dwiema metodami: Log oraz LogError.
 * Metoda LogError ma domyślną implementację, co oznacza, że każda klasa implementująca ten interfejs ma tę metodę dostępną automatycznie,
 * nawet jeśli nie dostarczy swojej własnej implementacji.
 *
 * Klasa ConsoleLogger implementuje interfejs ILogger i dostarcza swoją własną implementację metody Log.
 * Jednakże, nie dostarcza własnej implementacji metody LogError, więc korzysta z domyślnej implementacji zdefiniowanej w interfejsie.
 *
 * Podczas uruchomienia programu, widzimy, że możemy wywołać metodę Log zdefiniowaną w interfejsie oraz wywołać domyślną metodę LogError,
 * która nie wymaga implementacji w klasie ConsoleLogger, ponieważ ma domyślną implementację w interfejsie.
 * Default interface methods pozwalają na dodawanie nowych funkcji do istniejących interfejsów bez łamania istniejących implementacji.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp8
{
    public class DefaultInterfaceMethodsExercise : ExerciseBase
    {
        public override void Run()
        {
            // Utworzenie obiektu ConsoleLogger
            ILogger consoleLogger = new ConsoleLogger();

            // Wywołanie metody zdefiniowanej w interfejsie
            consoleLogger.Log("Information message");

            // Wywołanie domyślnej metody interfejsu
            consoleLogger.LogError("Critical error!");
        }
    }

    public interface ILogger
    {
        void Log(string message);

        // Domyślna implementacja metody interfejsu
        // Implementacja ta jest dostępna dla wszystkich klas implementujących ten interfejs
        void LogError(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {errorMessage}");
            Console.ResetColor();
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
