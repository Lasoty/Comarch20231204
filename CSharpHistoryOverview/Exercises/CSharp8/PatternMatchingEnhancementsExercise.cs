using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp8
{
    public class PatternMatchingEnhancementsExercise : ExerciseBase
    {
        public override void Run()
        {
            RunSwitchExpressions();
            RunPropertyPatterns();
            RunTuplePatterns();
            RunPositionalPatterns();
        }

        /// <summary>
        /// Switch Expressions: Wykorzystuje switch expressions do przypisywania wartości na podstawie wyboru.
        /// </summary>
        void RunSwitchExpressions()
        {
            Console.WriteLine("=== Switch Expressions ===");
            int option = 2;

            string result = option switch
            {
                1 => "Option 1",
                2 => "Option 2",
                3 => "Option 3",
                _ => "Invalid Option"
            };

            Console.WriteLine($"Selected option: {result}\n");
        }

        /// <summary>
        /// Property Patterns: Sprawdza, czy obiekt zawiera właściwość o określonej wartości.
        /// </summary>
        void RunPropertyPatterns()
        {
            Console.WriteLine("=== Property Patterns ===");
            var person = new Person { Name = "Alice", Age = 30 };

            if (person is { Age: 30 })
            {
                Console.WriteLine($"{person.Name} is 30 years old.\n");
            }
            else
            {
                Console.WriteLine("Age doesn't match.\n");
            }
        }

        /// <summary>
        /// Tuple Patterns: Określa położenie na podstawie krotek.
        /// </summary>
        void RunTuplePatterns()
        {
            Console.WriteLine("=== Tuple Patterns ===");
            var coordinates = (5, 10);

            string location = coordinates switch
            {
                (0, 0) => "Origin",
                (var x, 0) => $"On X-axis at {x}",
                (0, var y) => $"On Y-axis at {y}",
                (_, _) => "Somewhere in space"
            };

            Console.WriteLine($"Coordinates are at {location}\n");
        }

        /// <summary>
        /// Positional Patterns: Sprawdza położenie na podstawie struktury lub klasy z zaimplementowanym interfejsem Deconstruct.
        /// </summary>
        void RunPositionalPatterns()
        {
            Console.WriteLine("=== Positional Patterns ===");
            var point = new Point(3, 4);

            string position = point switch
            {
                Point(0, 0) => "Origin",
                Point(var x, var y) => $"At ({x}, {y})",
                _ => "Somewhere else"
            };

            Console.WriteLine($"The point is located {position}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }
}
