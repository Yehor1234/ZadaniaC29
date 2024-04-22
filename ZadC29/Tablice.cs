using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadC29
{
    public class Tablice
    {
        public void Wyswietl(int[] tab)
        {
            for(int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i] + ",");
            }
           
        }
        public int[] Tworzenie_tablicy()
        {
            Console.WriteLine("ile znaków ma mieć tablica");
            int dl = int.Parse(Console.ReadLine());
            int[] ints = new int[dl];
            for (int i = 0; i < dl; i++)
            {
                Console.Write("podaj kolejny element");
                ints[i] = int.Parse(Console.ReadLine()) ;
            }
            return ints;
        }
    }
}
