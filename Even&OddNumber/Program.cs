using System;

namespace Even_OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podając liczbę sprawdzimy czy jest parzysta lub nieparzysta: ");
            var number = GetNumber();
            if (number % 2 == 0)
            {
                Console.WriteLine("\nPodana liczba jest PARZYSTA");
            }
            else
            {
                Console.WriteLine("\nPodana liczba jest NIEPARZYSTA");
            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłową liczbę. Możesz spróbować ponownie.\n");
                    continue;
                }
                return number;
            }
        }
    }
}


