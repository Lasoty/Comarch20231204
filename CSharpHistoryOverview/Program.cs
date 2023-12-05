using CSharpHistoryOverview.Exercises;
using CSharpHistoryOverview.Exercises.CSharp20;
using CSharpHistoryOverview.Exercises.CSharp60;
using CSharpHistoryOverview.Exercises.CSharp70;
using CSharpHistoryOverview.Exercises.CSharp71;
using CSharpHistoryOverview.Exercises.CSharp8;
using CSharpHistoryOverview.Exercises.CSharp9;

public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            ShowTitle();
            ShowMenu();

            if (int.TryParse(Console.ReadLine(), out var select))
            {
                switch (select)
                {
                    case 1:
                        ShowCSharp20SubMenu();
                        break;
                    case 2:
                        ShowCSharp60SubMenu();
                        break;
                    case 3:
                        ShowCSharp70SubMenu();
                        break;
                    case 4:
                        ShowCSharp73SubMenu();
                        break;
                    case 5:
                        ShowCSharp8SubMenu();
                        break;
                    case 9:
                        ShowCSharp9SubMenu();
                        break;

                    default:
                        ShowError("Wybrana pozycja jest nieprawidłowa!");
                        break;
                }
            }
            else
            {
                ShowError("Wprowadzona wartość jest nieprawidłowa!");
            }

        } while (true);
    }



    private static void ShowCSharp20SubMenu()
    {
        Console.Clear();
        Console.WriteLine(" 1. Typy generyczne");
        Console.WriteLine(" 2. Delegaty");
        Console.WriteLine(" 3. Iteratory");
        Console.WriteLine(" 4. Metody rozszerzające");
        Console.WriteLine(" 5. Wyrażenia lambda");
        Console.WriteLine(" 6. Typy anonimowe");
        Console.WriteLine(" 7. Operatory LINQ");
        Console.Write("Wybierz pozycję menu: ");

        if (int.TryParse(Console.ReadLine(), out var select))
        {
            ExerciseBase? exercise = null;
            switch (select)
            {
                case 1:
                    exercise = new GenericTypesExercise();
                    break;
                case 2:
                    exercise = new DelegatesExercise();
                    break;
                case 3:
                    exercise = new IteratorExercise();
                    break;
                case 4:
                    exercise = new ExtensionMethodsExercise();
                    break;
                case 5:
                    exercise = new LambdaExpressionsExercise();
                    break;
                case 6:
                    exercise = new AnonymousTypesExercise();
                    break;
                case 7:
                    exercise = new LinqOperatorsExercise();
                    break;
                default:
                    ShowError("Wybrana pozycja jest nieprawidłowa!");
                    break;
            }

            if (exercise != null) 
                StartExercise(exercise.Run);            
        }
        else
        {
            ShowError("Wprowadzona wartość jest nieprawidłowa!");
        }
    }
    
    private static void ShowCSharp60SubMenu()
    {
        Console.Clear();
        Console.WriteLine(" 1. Inicjalizatory automatycznie implementowanych właściwości");
        Console.WriteLine(" 2. Operator nameof");
        Console.WriteLine(" 3. Inicjalizator indexerów");
        Console.WriteLine(" 4. Interpolacja napisów");
        Console.WriteLine(" 5. Propagator wartości null");
        Console.WriteLine(" 6. Filtry wyjątków");
        Console.WriteLine(" 7. Jedno wyrażeniowe składowe klasy");
        Console.WriteLine(" 8. Await w sekcji catch/finally");
        Console.WriteLine(" 9. Statyczny import");
        Console.Write("Wybierz pozycję menu: ");

        if (int.TryParse(Console.ReadLine(), out var select))
        {
            ExerciseBase? exercise = null;
            switch (select)
            {
                case 1:
                    exercise = new PropertiesInitializatiorsExercise();
                    break;
                case 2:
                    exercise = new NameofOperatorExercise(); 
                    break;
                case 3:
                    exercise = new IntexerInitExercise();
                    break;
                case 4:
                    exercise = new StringInterpolationExercise();
                    break;
                case 5:
                    exercise = new NullPropagationExercise();
                    break;
                case 6:
                    exercise = new ExceptionFiltersExercise();
                    break;
                case 7:
                    exercise = new ExpressionBodiedMembersExercise();
                    break;
                case 8:
                    exercise = new AwaitableCatchExercise();
                    break;
                case 9:
                    exercise = new StaticImportExercise();
                    break;
                default:
                    ShowError("Wybrana pozycja jest nieprawidłowa!");
                    break;
            }

            if (exercise != null)
                StartExercise(exercise.Run);
        }
        else
        {
            ShowError("Wprowadzona wartość jest nieprawidłowa!");
        }
    }
    
    private static void ShowCSharp70SubMenu()
    {
        Console.Clear();
        Console.WriteLine(" 1. Krotki oraz dekonstrukcje");
        Console.WriteLine(" 2. Dopasowanie do wzorca");
        Console.WriteLine(" 3. Funkcje lokalne");
        Console.WriteLine(" 4. Zmienne deklarowane za pomocą out");
        Console.WriteLine(" 5. Throw jako wyrażenie");
        Console.Write("Wybierz pozycję menu: ");

        if (int.TryParse(Console.ReadLine(), out var select))
        {
            ExerciseBase? exercise = null;
            switch (select)
            {
                case 1:
                    exercise = new TuplesAndDeconstructionExercise();
                    break;
                case 2:
                    exercise = new PatternMatchingExercise();
                    break;
                case 3:
                    exercise = new LocalFunctionsExercise();
                    break;
                case 4:
                    exercise = new OutVariablesExercise();
                    break;
                case 5:
                    exercise = new ThrowExpressionsExercise();
                    break;
                default:
                    ShowError("Wybrana pozycja jest nieprawidłowa!");
                    break;
            }

            if (exercise != null)
                StartExercise(exercise.Run);
        }
        else
        {
            ShowError("Wprowadzona wartość jest nieprawidłowa!");
        }
    }

    private static void ShowCSharp73SubMenu()
    {
        Console.Clear();
        Console.WriteLine(" 1. Dopasowanie do wzorca i typy generyczne");
        Console.WriteLine(" 2. Wnioskowanie nazwanych krotek");
        Console.WriteLine(" 3. Modyfikator dostępu private protected");
        Console.Write("Wybierz pozycję menu: ");

        if (int.TryParse(Console.ReadLine(), out var select))
        {
            ExerciseBase? exercise = null;
            switch (select)
            {
                case 1:
                    exercise = new PatternMatchingExercise71();
                    break;
                case 2:
                    exercise = new InferredTupleElementNamesExercise();
                    break;
                case 3:
                    exercise = new ProtectedPrivateModificatorExercise();
                    break;
                default:
                    ShowError("Wybrana pozycja jest nieprawidłowa!");
                    break;
            }

            if (exercise != null)
                StartExercise(exercise.Run);
        }
        else
        {
            ShowError("Wprowadzona wartość jest nieprawidłowa!");
        }
    }

    private static void ShowCSharp8SubMenu()
    {
        Console.Clear();
        Console.WriteLine(" 1. Rozszerzenia dla dopasowania do wzorca");
        Console.WriteLine(" 2. Nullowane typy referencyjne");
        Console.WriteLine(" 3. Asynchroniczne strumienie");
        Console.WriteLine(" 4. Domyślnie implementowane składowe interfejsów");
        Console.WriteLine(" 5. Przedziały");
        Console.Write("Wybierz pozycję menu: ");

        if (int.TryParse(Console.ReadLine(), out var select))
        {
            ExerciseBase? exercise = null;
            switch (select)
            {
                case 1:
                    exercise = new PatternMatchingEnhancementsExercise();
                    break;
                case 2:
                    exercise = new NullableReferenceTypesExercise();
                    break;
                case 3:
                    exercise = new AsynchronousStreamsExercise();
                    break;
                case 4:
                    exercise = new DefaultInterfaceMethodsExercise();
                    break;
                case 5:
                    exercise = new IndicesAndRangesExercise();
                    break;
                default:
                    ShowError("Wybrana pozycja jest nieprawidłowa!");
                    break;
            }

            if (exercise != null)
                StartExercise(exercise.Run);
        }
        else
        {
            ShowError("Wprowadzona wartość jest nieprawidłowa!");
        }

    }

    private static void ShowCSharp9SubMenu()
    {
        Console.Clear();
        Console.WriteLine(" 1. Rozszerzenia dla dopasowania do wzorca");
        Console.WriteLine(" 2. Rekordy");
        Console.WriteLine(" 3. Settery typu init");
        Console.WriteLine(" 4. Argument wyrażenia lambda \"_\"");
        Console.WriteLine(" 5. GetEnumerator dla pętli foreach");
        Console.Write("Wybierz pozycję menu: ");

        if (int.TryParse(Console.ReadLine(), out var select))
        {
            ExerciseBase? exercise = null;
            switch (select)
            {
                case 1:
                    exercise = new RelationalAndLogicalPatternsExercise();
                    break;
                case 2:
                    exercise = new RecordsExercise();
                    break;
                case 3:
                    exercise = new InitOnlySettersExercise();
                    break;
                case 4:
                    exercise = new LambdaDiscardParametersExercise();
                    break;
                case 5:
                    exercise = new ExtensionGetEnumeratorSupportExercise();
                    break;
                default:
                    ShowError("Wybrana pozycja jest nieprawidłowa!");
                    break;
            }

            if (exercise != null)
                StartExercise(exercise.Run);
        }
        else
        {
            ShowError("Wprowadzona wartość jest nieprawidłowa!");
        }

    }

    private static void StartExercise(Action exercise)
    {
        Console.Clear();
        exercise();
        ShowEndExercise();
    }

    private static void ShowMenu()
    {
        Console.WriteLine(" 1. C# 2 / C# 3 LINQ");
        Console.WriteLine(" 2. C# 6");
        Console.WriteLine(" 3. C# 7");
        Console.WriteLine(" 4. C# 7.1, 7.2, 7.3");
        Console.WriteLine(" 5. C# 8");
        Console.WriteLine(" 6. C# 9");
        Console.WriteLine(" 7. C# 10");

        Console.Write("Wybierz pozycję menu: ");
    }

    private static void ShowTitle()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("NOWOCZESNY C# - Ćwiczenia");
        Console.ResetColor();
    }

    private static void ShowEndExercise()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Koniec ćwiczenia. Naciśnij dowolny przycisk ...");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();
    }

    private static void ShowError(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(msg);
        Console.ResetColor();
        Console.ReadLine();
        Console.Clear();
    }
}