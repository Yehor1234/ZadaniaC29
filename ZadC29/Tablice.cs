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
        {
         
            for (int i = 0;i < tablica.Length;i++)
            {
                for (int j = 1; j<tablica.Length-i;j++)
                    if (tablica[j-1] > tablica[j])
                    {
                        int temp = tablica[j-1]; tablica[j-1] = tablica[j]; tablica[j] = temp ;
                    }
                }
            }
        }
        public bool Przeszukaj(int[] tab)
        {
         Console.WriteLine("Jakiej liczby szukasz w tablicy? ");
            int szukana = int.Parse(Console.ReadLine());
            for(int i = 0; i < tab.Length ; i++)
            {
                if (tab[i] == szukana)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
