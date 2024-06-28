using System;

namespace Zadanie_3
{
    public class Employee
    {
        private string name;
        private string lastname;
        private string street;
        private string city;

        protected void Read()
        {
            Console.WriteLine("Podaj imię pracownika:");
            name = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko pracownika:");
            lastname = Console.ReadLine();

            Console.WriteLine("Podaj ulicę pracownika:");
            street = Console.ReadLine();

            Console.WriteLine("Podaj miasto pracownika:");
            city = Console.ReadLine();
        }

        protected void Show()
        {
            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"Nazwisko: {lastname}");
            Console.WriteLine($"Ulica: {street}");
            Console.WriteLine($"Miasto: {city}");
        }
    }

    public class HR : Employee
    {
        private string education;
        private string businessrole;

        public void Read1()
        {
            Read();
            Console.WriteLine("Wpisz wykszstałcenie:");
            education = Console.ReadLine();
            Console.WriteLine("Wpisz stanowisko:");
            businessrole = Console.ReadLine();
        }

        public void Show1()
        {
            Show();
            Console.WriteLine($"Wykształcenie: {education}");
            Console.WriteLine($"Stanowisko: {businessrole}");
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