using System;
class Program
{
    static void Main(string[] args)
    {
     
        int[] tablica = RandTablica(10);
        Console.WriteLine("Tablica przed sortowaniem: ");
        WypiszN(tablica);


        SortowanieBabelkowe(tablica);
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
    static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    int temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;
                }
            }
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

