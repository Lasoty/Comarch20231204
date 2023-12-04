/*
 * Ten przykład demonstruje użycie operatorów LINQ Where do filtrowania liczb parzystych
 * i Select do obliczania kwadratów liczb w kolekcji.
 * Wyrażenia lambda są używane jako argumenty tych operatorów, co umożliwia filtrowanie i mapowanie danych.
 * Po uruchomieniu programu w konsoli zostaną wyświetlone liczby parzyste z listy oraz ich kwadraty,
 * które zostały obliczone przy użyciu operatorów LINQ.
 * Operatorzy LINQ są potężnym narzędziem w C#, które umożliwiają manipulację danymi w kolekcjach,
 * filtrowanie, mapowanie i wiele innych operacji.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp20
{
    public class LinqOperatorsExercise : ExerciseBase
    {
        public override void Run()
        {
            // Lista liczb całkowitych
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Użycie operatora Where do wyfiltrowania liczb parzystych
            var evenNumbers = numbers.Where(num => num % 2 == 0);

            // Użycie operatora Select do mapowania liczb na ich kwadraty
            var squares = numbers.Select(num => num * num);

            Console.WriteLine("Liczby parzyste:");
            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Kwadraty liczb:");
            foreach (var num in squares)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }
    }
}
