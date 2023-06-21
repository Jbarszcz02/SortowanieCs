using System;
class Program
{
    static void Main(string[] args)
    {

        int[] tablica = RandTablica(10);
        Console.WriteLine("Tablica przed sortowaniem: ");
        WypiszN(tablica);


        SortowaniePrzezWstawianie(tablica);
        Console.WriteLine("Tablica po sortowaniu");
        WypiszN(tablica);

    }

    static int[] RandTablica(int rozmiar)
    {
        int[] tablica = new int[rozmiar];

        Random rand = new Random();

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rand.Next(1, 100);

        }
        return tablica;

    }
    static void SortowaniePrzezWstawianie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 1; i < n; i++)
        {
            int x = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > x)
            {
                tablica[j + 1] = tablica[j];
                j = j - 1;
            }

            tablica[j + 1] = x;
        }
    }

    static void WypiszN(int[] tablica)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine(tablica[i]);
        }
    }
}

