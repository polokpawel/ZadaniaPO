using System;

namespace Zadanie_2
{
    public class Sorter
    {
        private int[] liczba;

        public void read_data()
        {
            liczba = new int[6];
            Console.WriteLine("Podaj sześć liczb, aby je posortować:");
            for (var i = 0; i < 6; i++)
            {
                Console.WriteLine($"Podaj liczbę {i + 1}:");
                liczba[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void process_data()
        {
            Array.Sort(liczba);
        }

        public void show_results()
        {
            Console.WriteLine("Posortowane liczby:");
            foreach (var number in liczba)
            {
                Console.WriteLine(number);
            }
        }
    }

    internal abstract class Program
    {
        public static void Main()
        {
            var sorter = new Sorter();
            sorter.read_data();
            sorter.process_data();
            sorter.show_results();
        }
    }
}