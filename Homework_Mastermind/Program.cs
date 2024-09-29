using System.Security.Cryptography.X509Certificates;

namespace Homework_Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Udvozlo();
            Kiertekeles();
        }


        #region Üdvözlő
        public static void Udvozlo()
        {
            Console.WriteLine("Üdvözöllek a Barkóba játékomban!\n\n" +
              "Próbáld meg kitalálni a lehető legkevesebb próbálkozással milyen számra gondoltam...");
        }
        #endregion
        #region Szám bekérése és TryParse
        public static int SzamBekeres()
        {
            int tipp;
            bool sikeresSzambekeres;

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

            return tipp;
        }
        #endregion
        #region A tipp és a gondolt szám kiértékelése
        public static void Kiertekeles()
        {
            Random random = new Random();
            int gondoltSzam = random.Next(1, 1001);
            int tippekSzama = 0;
            bool talalat = false;

            while (!talalat)
            {
                int tipp = SzamBekeres();
                tippekSzama++;

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
        #endregion
    }
}
