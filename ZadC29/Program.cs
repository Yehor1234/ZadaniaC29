using ZadC29;

class PlikGłówny
{
    static void Main(string[] args)
    {
    Tablice tablica = new Tablice();
        int[] tab = tablica.Tworzenie_tablicy();

        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}