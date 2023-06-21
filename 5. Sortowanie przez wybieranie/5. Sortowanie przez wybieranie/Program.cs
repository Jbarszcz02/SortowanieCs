using System;
class Program
{
    static void Main(string[] args)
    {

        int[] tablica = RandTablica(10);
        Console.WriteLine("Tablica przed sortowaniem: ");
        WypiszN(tablica);


        SortowaniePrzezWybieranie(tablica);
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
    static void SortowaniePrzezWybieranie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = tablica[minIndex];
            tablica[minIndex] = tablica[i];
            tablica[i] = temp;
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

