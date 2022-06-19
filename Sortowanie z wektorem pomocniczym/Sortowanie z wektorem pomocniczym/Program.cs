using System;

namespace Sortowanie_z_wektorem_pomocniczym
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] tab = {33, 155, 12, 1, 12, 19, 7, 147,111, 10, 169, 16, 254, 111, 102, 15, 4, 124};
                int[] tab2 = new int[tab.Length]; // tworzymy nową tabelę, która będzie przechowywała posortowany zbiór
                int min_index; //zmienna pomocnicza, która przechowuje indeks komórki z najmniejszą wartością w tablicy

                for (int i = 0; i < (tab.Length); i++)
                {
                    min_index = i;
                    for (int j = 0; j < (tab.Length); j++) //pętla wyszukuje najmniejszy element w tablicy
                        if (tab[j] < tab[min_index])
                            min_index = j;

                  
                    tab2[i] = tab[min_index];  //wstawiamy najmniejszy element do nowej tablicy
                    tab[min_index] = int.MaxValue; // wstawiamy największą możliwą wartość w miejsce najniższej znalezionej wartości,
                                                    // dzięki czemu nie zostanie ona pobrana drugi raz, a zostanie 'odhaczona'.


                }
                foreach (var item in tab2)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

