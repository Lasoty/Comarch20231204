/*
 * W tym przykładzie mamy klasę MyDictionary z indexerem pozwalającym na odczyt i zapis danych.
 * Dzięki inicjalizatorowi indexerów, podczas tworzenia instancji klasy MyDictionary,
 * możemy od razu inicjalizować wartości dla określonych kluczy.
 * W sekcji Main tworzona jest instancja MyDictionary,
 * a następnie przy użyciu inicjalizatora indexerów przypisywane są wartości dla kluczy "key1", "key2" i "key3".
 * Następnie wartości te są wyświetlane przy użyciu tego samego indexer'a.
 *
 * Dzięki temu mechanizmowi można w łatwy sposób zainicjalizować indeksowane dane
 * podczas tworzenia instancji klasy z indexerem, co może być przydatne przy pracy z różnymi strukturami danych.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp60
{
    internal class IntexerInitExercise : ExerciseBase
    {
        public override void Run()
        {
            // Inicjalizacja klasy z indexerem
            MyDictionary dictionary = new MyDictionary
            {
                ["key1"] = "value1",
                ["key2"] = "value2",
                ["key3"] = "value3"
            };

            // Wyświetlenie wartości z indexerem
            Console.WriteLine($"Wartość dla klucza 'key1': {dictionary["key1"]}");
            Console.WriteLine($"Wartość dla klucza 'key2': {dictionary["key2"]}");
            Console.WriteLine($"Wartość dla klucza 'key3': {dictionary["key3"]}");

        }
    }

    // Klasa z indexerem wykorzystującym inicjalizator indexerów
    class MyDictionary
    {
        private Dictionary<string, string> data = new Dictionary<string, string>();

        public string this[string key]
        {
            get => data.ContainsKey(key) ? data[key] : null;
            set => data[key] = value;
        }
    }
}
