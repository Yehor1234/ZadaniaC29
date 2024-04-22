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
        public void Sortowanie_babelkowe(int[] tablica)
        {
         
            for (int i = 0;i < tablica.Length;i++)
            {
                for (int j = 1; j<tablica.Length-i;j++)
                {
                    if (tablica[j-1] > tablica[j])
                    {
                        int temp = tablica[j-1]; tablica[j-1] = tablica[j]; tablica[j] = temp ;
                    }
                }
            }
        }
        public void Przeszukaj(int[] tab)
        {
         Console.WriteLine("Jakiej liczby szukasz w tablicy? ");
            int szukana = int.Parse(Console.ReadLine());
            bool liczba_istnieje = false;
            int ile_razy = 0;
            for (int i = 0; i<tab.Length ; i++) {
             if (tab[i] == szukana)
                {
                    liczba_istnieje= true;
                    ile_razy++;
                }
                
            
            }
            if (liczba_istnieje) 
            {
                Console.WriteLine($"liczba występuje w tablicy {ile_razy} ");
            }
            else 
            {
                Console.WriteLine("Liczba nie występuje w tablicy");
                    
           }
        }
    }
}
