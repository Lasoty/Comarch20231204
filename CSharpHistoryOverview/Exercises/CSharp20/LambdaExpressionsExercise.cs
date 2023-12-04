using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp20
{
    public class LambdaExpressionsExercise : ExerciseBase
    {
        public override void Run()
        {
            FirstExample();
            SecondExample();
            ThirdExample();
        }

        /*
         * W tym przykładzie użyliśmy metody FindAll na liście liczb całkowitych (numbers) w celu filtrowania liczb parzystych.
         * Wyrażenie lambda x => x % 2 == 0 jest przekazane jako argument do metody FindAll.
         * To wyrażenie lambda sprawdza, czy liczba jest parzysta poprzez wykonanie operacji modulo (%),
         * gdzie liczba dzielona jest przez 2, a reszta jest równa 0.
         * Efektem tego wyrażenia lambda jest lista evenNumbers, która zawiera tylko liczby parzyste z początkowej listy numbers.
         * Po wykonaniu operacji filtrowania wyświetlamy te liczby parzyste w konsoli.
         */
        private void FirstExample()
        {
            Console.WriteLine("Przykład nr 1. ");
            // Tworzymy listę liczb całkowitych
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Użycie wyrażenia lambda do filtrowania liczb parzystych
            List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

            Console.WriteLine("Liczby parzyste:");
            foreach (int num in evenNumbers)
            {
                Console.Write(num + " ");
            }
        }
        
        /*
         * W tym przykładzie użyto wyrażenia lambda do sortowania listy pracowników według wynagrodzenia (Salary).
         * Metoda Sort listy przyjmuje delegat Comparison<T>, który jest odpowiedzialny za porównywanie dwóch elementów.
         *
         * Wyrażenie lambda emp1.Salary.CompareTo(emp2.Salary) służy jako kryterium sortowania.
         * Porównuje ono wynagrodzenie dwóch pracowników (emp1 i emp2) i zwraca wartość wskazującą,
         * czy pierwszy pracownik powinien być przed drugim w posortowanej liście.
         *
         * Następnie lista pracowników jest sortowana na podstawie tego kryterium,
         * a wynik jest wyświetlany w konsoli, prezentując posortowaną listę pracowników według ich wynagrodzenia.
         */
        private void SecondExample()
        {
            Console.WriteLine("Przykład nr 2");

            // Tworzymy listę pracowników
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Anna", Salary = 4500 },
                new Employee { Id = 2, Name = "Marcin", Salary = 3800 },
                new Employee { Id = 3, Name = "Kamil", Salary = 5000 },
                new Employee { Id = 4, Name = "Ewa", Salary = 4200 }
            };

            // Sortowanie pracowników po wynagrodzeniu przy użyciu wyrażenia lambda
            employees.Sort((emp1, emp2) => emp1.Salary.CompareTo(emp2.Salary));

            // Wyświetlanie posortowanej listy pracowników
            Console.WriteLine("Posortowani pracownicy według wynagrodzenia:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}, Imię: {employee.Name}, Wynagrodzenie: {employee.Salary}");
            }
        }

        /*
         * Ten przykład ilustruje kilka zastosowań wyrażeń lambda:
         * 1. Tworzymy delegat Operacja, który może przechowywać referencję do metody anonimowej lub wyrażenia lambda.
         * 2. Definiujemy wyrażenie lambda dodawanie, które dodaje dwie liczby.
         * 3. Definiujemy wyrażenie lambda kwadrat, które oblicza kwadrat liczby.
         * 4. Wywołujemy wyrażenia lambda i wyświetlamy wyniki.
         *
         * To proste demo ilustruje jak wyrażenia lambda mogą być używane do tworzenia anonimowych funkcji
         * i przypisywania ich do delegatów lub zmiennych typu Func/Action w C#.
         */
        private void ThirdExample()
        {
            Console.WriteLine("Przykład nr 3");

            // Przykład wyrażenia lambda dodającego dwie liczby
            Operacja dodawanie = (a, b) => a + b;

            // Wywołanie wyrażenia lambda
            int suma = dodawanie(5, 3);
            Console.WriteLine("Wynik dodawania: " + suma);

            // Przykład wyrażenia lambda obliczającego kwadrat liczby
            Func<int, int> kwadrat = x => x * x;

            // Wywołanie wyrażenia lambda
            int wynikKwadratu = kwadrat(4);
            Console.WriteLine("Kwadrat liczby 4: " + wynikKwadratu);

        }
    }

    delegate int Operacja(int x, int y);

    // Klasa reprezentująca obiekt Employee
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
}
