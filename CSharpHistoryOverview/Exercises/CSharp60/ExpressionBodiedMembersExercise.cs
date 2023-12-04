/*
 * W tym przykładzie klasa Product ma właściwości Name i Price, a także konstruktor jedno wyrażeniowy,
 * który inicjalizuje te właściwości. Wyrażenie (Name, Price) = (name, price) użyte w konstruktorze wykorzystuje tuple
 * do zainicjalizowania właściwości Name i Price.
 *
 * Metoda GetDescription również została zaimplementowana jako jedno wyrażeniowe składowe klasy.
 * Zamiast używania pełnej deklaracji metody, wykorzystano jedno wyrażenie =>, które zwraca sformatowany opis produktu.
 *
 * Jedno wyrażeniowe składowe klasy pozwalają na bardziej zwięzłą składnię w klasach,
 * co sprawia, że kod jest bardziej czytelny i łatwiejszy do zrozumienia, szczególnie dla prostych metod lub właściwości,
 * które mogą być zapisane w jednej linii.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp60
{
    public class ExpressionBodiedMembersExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzenie obiektu klasy Product i wywołanie jej metody
            Product product = new Product("Laptop", 1500);
            Console.WriteLine(product.GetDescription());
        }
    }

    class Product
    {
        public string Name { get; }
        public decimal Price { get; }

        // Jedno wyrażeniowe składowe klasy dla konstruktora
        public Product(string name, decimal price) => (Name, Price) = (name, price);

        // Jedno wyrażeniowe składowe klasy dla metody
        public string GetDescription() => $"{Name} - cena: {Price:C}";
    }
}
