using System;

namespace Zadanie_3
{
    public class Employee
    {
        private string imie;
        private string nazwisko;
        private string ulica;
        private string miasto;

        protected void Read()
        {
            Console.WriteLine("Podaj imię pracownika:");
            imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko pracownika:");
            nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj ulicę pracownika:");
            ulica = Console.ReadLine();

            Console.WriteLine("Podaj miasto pracownika:");
            miasto = Console.ReadLine();
        }

        protected void Show()
        {
            Console.WriteLine($"Imię: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Ulica: {ulica}");
            Console.WriteLine($"Miasto: {miasto}");
        }
    }

    public class HR : Employee
    {
        private string edukacja;
        private string stanowisko;

        public void Read1()
        {
            Read();
            Console.WriteLine("Wpisz wykszstałcenie:");
            edukacja = Console.ReadLine();
            Console.WriteLine("Wpisz stanowisko:");
            stanowisko = Console.ReadLine();
        }

        public void Show1()
        {
            Show();
            Console.WriteLine($"Wykształcenie: {edukacja}");
            Console.WriteLine($"Stanowisko: {stanowisko}");
        }
    }

    internal abstract class Program
    {
        public static void Main()
        {
            var hrEmployee = new HR();
            hrEmployee.Read1();
            hrEmployee.Show1();
        }
    }
}