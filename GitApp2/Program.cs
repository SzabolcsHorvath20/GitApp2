using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp2
{
    class Program
    {
        static List<int> szamok = new List<int>();
        static void Bekeres()
        {
            Console.WriteLine("Hány számot szeretne megadni?");
            string darabszam_keres = Console.ReadLine();
            var isNumeric = int.TryParse(darabszam_keres, out int darabszam);
            if (darabszam == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem adhat meg nullát, a program leáll!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Environment.Exit(0);
            }
            Hibaellenorzes(isNumeric);
            Console.WriteLine("Kérem adjon meg {0} számot!", darabszam);
            for (int i = 0; i < darabszam; i++)
            {
                Console.WriteLine(i+1 + ".");
                string bekert_ertek = Console.ReadLine();
                var isNumeric2 = int.TryParse(bekert_ertek, out int j);
                Hibaellenorzes(isNumeric2);

                szamok.Add(j);
            }
        }
        static void Hibaellenorzes(bool hiba)
        {
            if (hiba == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem számot adott meg, a program leáll!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        static void Kereses()
        {
            szamok.Sort();
            int seged = szamok[szamok.Count - 1];
            int seged2 = szamok[0];
            Console.WriteLine("A legnagyobb szám: " + seged);
            Console.WriteLine("A legkisebb szám: " + seged2);
        }
        static void Main(string[] args)
        {
            Bekeres();
            Kereses();
            Console.ReadKey();
        }
    }
}
