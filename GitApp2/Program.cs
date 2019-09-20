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
            Console.WriteLine("Kérem adjon meg 10 számot!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1 + ".");
                int j = Convert.ToInt32(Console.ReadLine());
                szamok.Add(j);
            }
        }
        static void Kereses()
        {
            szamok.Sort();
            int seged = szamok[szamok.Count - 1];
            Console.WriteLine(seged);
        }
        static void Main(string[] args)
        {
            Bekeres();
            Kereses();
            Console.ReadKey();
        }
    }
}
