using ZadC29;

class PlikGłówny
{
    static void Main(string[] args)
    {
    Tablice tablica = new Tablice();
        int[] tab = tablica.Tworzenie_tablicy();
        tablica.Wyswietl(tab);
        tablica.Sortowanie_babelkowe(tab);
        tablica.Wyswietl(tab);

        bool przeszukanie = tablica.Przeszukaj(tab)
            if(przeszukanie == true )
        {
            Console.WriteLine("Liczba jest w tablicy");
        }
            else
        {

            Console.WriteLine("Liczby nie ma w tablicy");
                
                
                }
    }
}