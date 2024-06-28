using System;

namespace Zadanie_1
{
    public class Rectangle
    {
        private double a;
        private double b;
        private double pole;

        public void read_data()
        {
            Console.WriteLine("Podaj długość boku a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj długość boku b:");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public void process_data()
        {
            pole = a * b;
        }

        public void show_results()
        {
            Console.WriteLine($"Długość boku a wynosi: {a:F2}");
            Console.WriteLine($"Długość boku b wynosi: {b:F2}");
            Console.WriteLine($"Pole kwadratu: {pole:F2}");
        }
    }

    internal abstract class Program
    {
        public static void Main()
        {
            var rectangle = new Rectangle();
            rectangle.read_data();
            rectangle.process_data();
            rectangle.show_results();
        }
    }
}