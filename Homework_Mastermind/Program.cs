namespace Homework_Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöllek a Barkóba játékomban!\n\n" +
                              "Próbáld meg kitalálni a lehető legkevesebb próbálkozással milyen számra gondoltam...");

            // Deklaráció
            int tipp;
            int tippekSzama = 0;
            bool sikeresSzambekeres;
            Random random = new Random();
            int gondoltSzam = random.Next(1, 1001);
            bool talalat = false;

            while (!talalat)
            {
                // Szám bekérése és TryParse
                do
                {
                    Console.WriteLine("Kérem a tipped:");
                    string input = Console.ReadLine();
                    sikeresSzambekeres = int.TryParse(input, out tipp);

                    if (!sikeresSzambekeres)
                    {
                        Console.WriteLine("Kérlek számot adj meg!");
                    }
                }
                while (!sikeresSzambekeres);

                tippekSzama++;

                // A tipp és a gondolt szám kiértékelése
                if (gondoltSzam > tipp)
                {
                    Console.WriteLine("Nagyobb számra gondoltam!");
                }
                else if (gondoltSzam < tipp)
                {
                    Console.WriteLine("Kisebb számra gondoltam!");
                }
                else
                {
                    Console.WriteLine($"\n\nGratulálok! Eltaláltad a számot {tippekSzama} próbálkozásból.");
                    talalat = true; // A ciklus befejezéséhez
                }
            }
        }
    }
}
