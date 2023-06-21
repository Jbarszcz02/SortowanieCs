using System;
class Program
{
    static void Main(string[] args)
    {
        int[] tablica = RandTablica(10);

        Console.WriteLine("Normalna tablica: ");
        WypiszN(tablica);

        Console.WriteLine("Odwrócona tablica: ");
        Wypisz(tablica);

        Console.ReadLine();




    }

    static int [] RandTablica(int rozmiar)
    {
        int [] tablica = new int [rozmiar];
        
        Random rand = new Random();

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rand.Next(1, 100);

        }
        return tablica;

    }
    static void Wypisz(int[] tablica)
    {
        for( int i = tablica.Length - 1; i >= 0; i--) 
        {
            Console.WriteLine(tablica[i]);
        }
    }

    static void WypiszN(int[] tablica)
    {
        for (int i = 0; i< tablica.Length; i++)
        {
            Console.WriteLine(tablica[i]); 
        }
    }
}