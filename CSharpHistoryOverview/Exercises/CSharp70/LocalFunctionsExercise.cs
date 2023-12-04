/*
 * W tym przykładzie mamy dwie funkcje CalculateSquareArea i CalculateRectangleArea,
 * które obliczają pole kwadratu i prostokąta odpowiednio.
 * Wewnątrz tych funkcji zdefiniowano lokalne funkcje (CalculateAreaSquare i CalculateAreaRectangle),
 * które realizują faktyczne obliczenia.
 *
 * Korzystanie z lokalnych funkcji pozwala na uniknięcie powtarzania kodu,
 * ponieważ logika obliczeń jest izolowana wewnątrz lokalnych funkcji,
 * co sprawia, że kod jest bardziej czytelny i łatwiejszy w utrzymaniu.
 * Dodatkowo, lokalne funkcje mają dostęp do zmiennych z otaczającego zakresu,
 * co umożliwia przekazywanie wartości pomiędzy funkcjami.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHistoryOverview.Exercises.CSharp70
{
    public class LocalFunctionsExercise : ExerciseBase
    {
        public override void Run()
        {
            // Wywołanie metody CalculateSquareArea
            double squareArea = CalculateSquareArea(5);
            Console.WriteLine($"Pole kwadratu: {squareArea}");

            // Wywołanie metody CalculateRectangleArea
            double rectangleArea = CalculateRectangleArea(4, 6);
            Console.WriteLine($"Pole prostokąta: {rectangleArea}");
        }

        double CalculateSquareArea(double sideLength)
        {
            // Lokalna funkcja CalculateAreaSquare wyliczająca pole kwadratu
            double CalculateAreaSquare() => sideLength * sideLength;

            return CalculateAreaSquare(); // Wywołanie lokalnej funkcji
        }

        double CalculateRectangleArea(double length, double width)
        {
            // Lokalna funkcja CalculateAreaRectangle wyliczająca pole prostokąta
            double CalculateAreaRectangle() => length * width;

            return CalculateAreaRectangle(); // Wywołanie lokalnej funkcji
        }
    }
}
