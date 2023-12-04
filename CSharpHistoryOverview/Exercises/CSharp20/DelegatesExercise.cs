/*
 * W tym przykładzie EventPublisher jest wydawcą, który posiada delegata OnEventOccurred. 
 * Klasa EventSubscriber reprezentuje subskrybenta zdarzenia, który ma metodę HandleEvent, 
 * która jest wywoływana, gdy zdarzenie zostanie podniesione. W Run tworzymy instancje wydawcy i subskrybenta, 
 * subskrybujemy delegata, wywołujemy akcję i oczekujemy reakcji subskrybenta. 
 * Następnie anulujemy subskrypcję i ponownie wywołujemy akcję - tym razem subskrybent nie otrzyma zdarzenia, 
 * ponieważ został odsubskrybowany wcześniej.
 */

namespace CSharpHistoryOverview.Exercises.CSharp20
{
    public delegate void MyEventHandler(string message);

    public class DelegatesExercise : ExerciseBase
    {
        public override void Run()
        {
            // Tworzymy instancje wydawcy i subskrybenta zdarzenia
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();

            // Subskrybujemy delegata do zdarzenia
            publisher.OnEventOccurred += subscriber.HandleEvent;

            // Wywołujemy akcję, która powinna spowodować wywołanie zdarzenia
            publisher.PerformAction("Przykładowa akcja");

            // Usuwamy subskrypcję delegata
            publisher.OnEventOccurred -= subscriber.HandleEvent;

            // Ponowne wywołanie akcji - teraz nie powinno być reakcji subskrybenta
            publisher.PerformAction("Inna akcja");
        }
    }

    public class EventPublisher
    {
        // Delegat jako pole, które będzie przechowywało referencję do funkcji obsługi zdarzenia
        public MyEventHandler OnEventOccurred;

        // Metoda wywołująca zdarzenie
        public void PerformAction(string action)
        {
            // Wywołanie zdarzenia (jeśli jest subskrybowane)
            OnEventOccurred?.Invoke($"Wykonano akcję: {action}");
        }
    }

    public class EventSubscriber
    {
        public void HandleEvent(string message)
        {
            Console.WriteLine($"Otrzymano komunikat: {message}");
        }
    }
}
