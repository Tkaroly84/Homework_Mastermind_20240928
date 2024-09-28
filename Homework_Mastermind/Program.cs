namespace Homework_Mastermind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöllek a Barkóba játékomban!\n\n" +
                              "Próbáld meg kitalálni a lehető legkevesebb próbálkozással milyen számra gondoltam...");




//deklaráció
            int tipp;
            int tippekSzama = 0;
            bool sikeresSzambekeres;
            Random random = new Random();
            int gondoltSzam = random.Next(1, 1001);
            bool talalat = false;



            while (!talalat)
            {

//szám bekérése és TryParse
                do
                {
                    Console.WriteLine("Kérem a tipped:");
                    string input = Console.ReadLine();

                    sikeresSzambekeres = int.TryParse(input, out tipp);

                    if (!sikeresSzambekeres)
                    {
                        Console.WriteLine("Kérlek számot adj meg!");
                    }
                    sikeresSzambekeres = true;
                }
                while (!sikeresSzambekeres);

                tippekSzama++;
                //a tipp és a gondolt szám kiértékelése
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
                    Console.WriteLine($"\n\nGratulálok!\nA tippjed száma: {tippekSzama}");
                    talalat = true;
                }
            }

        }
    }
}
