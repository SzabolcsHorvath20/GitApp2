﻿using System;
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
            int darabszam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adjon meg {0} számot!", darabszam);
            for (int i = 0; i < darabszam; i++)
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
