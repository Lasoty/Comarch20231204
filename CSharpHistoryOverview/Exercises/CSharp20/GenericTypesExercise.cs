/*
 * Ten przykład demonstruje użycie generycznej klasy Stos, która może przechowywać elementy różnych typów. 
 * Tworzysz stos dla liczb całkowitych (Stos<int>) oraz dla napisów (Stos<string>). 
 * Metody Push dodają element do stosu, a metoda Pop zdejmuje i zwraca ostatni element ze stosu.
 * Zwróć uwagę na uniwersalność generycznych typów danych w C#, 
 * ponieważ mogą być stosowane dla różnych typów danych, co prowadzi do bardziej elastycznego i ponownie używalnego kodu.
 * 
 */

namespace CSharpHistoryOverview.Exercises.CSharp20
{
    internal class GenericTypesExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzenie stosu dla liczb całkowitych
            Stack<int> stosInt = new Stack<int>(5);

            stosInt.Push(10);
            stosInt.Push(20);
            stosInt.Push(30);

            Console.WriteLine("Zdejmowanie ze stosu liczb całkowitych:");
            Console.WriteLine(stosInt.Pop());
            Console.WriteLine(stosInt.Pop());
            Console.WriteLine(stosInt.Pop());

            // Tworzenie stosu dla napisów
            Stack<string> stosString = new Stack<string>(3);

            stosString.Push("jeden");
            stosString.Push("dwa");
            stosString.Push("trzy");

            Console.WriteLine("\nZdejmowanie ze stosu napisów:");
            Console.WriteLine(stosString.Pop());
            Console.WriteLine(stosString.Pop());
            Console.WriteLine(stosString.Pop());
        }
    }

    public class Stack<T>
    {
        private T[] items;
        private int index;

        public Stack(int size)
        {
            items = new T[size];
            index = 0;
        }

        public void Push(T item)
        {
            if (index < items.Length)
            {
                items[index] = item;
                index++;
            }
            else
            {
                Console.WriteLine("Stos jest pełny!");
            }
        }

        public T Pop()
        {
            if (index > 0)
            {
                index--;
                return items[index];
            }
            else
            {
                Console.WriteLine("Stos jest pusty!");
                return default(T);
            }
        }
    }
}
