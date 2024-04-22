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

        tablica.Przeszukaj(tab);
    }
}