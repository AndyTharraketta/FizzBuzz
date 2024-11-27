namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe:
            //Erstellen Sie einen Algorithmus der das Spiel FizzBuzz bis zur 100 durchführt.
            //Regeln siehe https://de.wikipedia.org/wiki/Fizz_buzz.

            //Modulo gibt uns den Rest einer Division als Ganzzahl zurück. Das Zeichen für den Operanten ist %
            //Beispiel: 4 % 2 = 0

            
            Console.WriteLine("Willkommen bei FizzBuzz!");
            for (int i = 1; i <= 100; i++) 
            {
                Thread.Sleep(1000);
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine("Spiel beendet!");


        }
    }
}
