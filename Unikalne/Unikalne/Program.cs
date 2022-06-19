using System;

namespace Unikalne //Algorytm w C#, który generuje losowe liczby z przedziału od 1 do 200, w taki sposób aby żadna z nich się nie powtarzała.

{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tablica = new int[15]; // Tworzymy tablicę, w której będziemy przechowywać wygenerowane liczby


            for (int i = 0; i < 15; i++)
            {
                Random liczba = new Random();

                int los = liczba.Next(1, 201); 
                for (int j = 0; j < i; j++)
                {
                    if (los != tablica[j]) // sprawdzamy czy liczba nie została już wcześniej wylosowana
                    {

                    }
                    else
                    {
                        los = liczba.Next(1, 201);   //ponieważ liczba się powtórzyła, losujemy nową i sprawdzamy od początku
                        j=0;                        
                    }
                }
                tablica[i] = los;



            }
            foreach (int item in tablica)
            {
                Console.WriteLine(item);
            }
        }
    }
}
