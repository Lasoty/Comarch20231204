/*
 * W poniższym przykładzie, using static HelperNamespace.MathHelper;
 * pozwala na bezpośrednie wywołanie metody CalculateCircleArea z klasy MathHelper bez wymagania pełnej nazwy kwalifikowanej MathHelper.
 * CalculateCircleArea. Dzięki temu skróceniu składni,
 * kod staje się bardziej czytelny i zwięzły, zwłaszcza w przypadku używania wielu metod statycznych
 * z tej samej klasy pomocniczej.
 */

namespace CSharpHistoryOverview.Exercises.CSharp60
{
    using static HelperNamespace.MathHelper;


    public class StaticImportExercise : ExerciseBase
    {
        public override void Run()
        {
            double radius = 5;

            // Dzięki statycznemu importowi, nie potrzebujemy używać pełnej nazwy kwalifikowanej
            double area = CalculateCircleArea(radius);

            Console.WriteLine($"Pole koła o promieniu {radius} wynosi: {area}");
        }
    }
}

namespace HelperNamespace
{
    public static class MathHelper
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}