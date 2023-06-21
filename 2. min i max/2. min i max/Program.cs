using System;
class Program
{
    static void Main(string[] args)
    {
        int min = 101;
        int max = 1; 
        int[] tablica = RandTablica(10);

        for (int i = 0; i < tablica.Length; i++)
        {

            if (tablica[i] < min)
            {
                min = tablica[i];

            }
            else if (tablica[i] > max)
            {
                max = tablica[i];
            }
        }
        Console.WriteLine("Normalna tablica: ");
        WypiszN(tablica);

        Console.WriteLine("Największa liczba z tej tablicy to: ");
        Console.WriteLine(max);

        Console.WriteLine("Najmniejsza liczba z tej tablicy to: ");
        Console.WriteLine(min);


        Console.ReadLine();




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

    static void WypiszN(int[] tablica)
    {
    for (int i = 0; i < tablica.Length; i++)
    {
        Console.WriteLine(tablica[i]);
    }
    }
}
