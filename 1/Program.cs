
namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1а: !(!A && !B) && A");
            Console.WriteLine("A\tB\tResult");
            bool[] values = { false, true };
            foreach (bool A in values)
                foreach (bool B in values)
                {
                    bool res = !(!A && !B) && A;
                    Console.WriteLine($"{A}\t{B}\t{res}");
                }

            Console.WriteLine("\nЗадание 1б: !(!A || !B) || A");
            Console.WriteLine("A\tB\tResult");
            foreach (bool A in values)
                foreach (bool B in values)
                {
                    bool res = !(!A || !B) || A;
                    Console.WriteLine($"{A}\t{B}\t{res}");
                }

            Console.WriteLine("\nЗадание 1в: !(!A || !B) && B");
            Console.WriteLine("A\tB\tResult");
            foreach (bool A in values)
                foreach (bool B in values)
                {
                    bool res = !(!A || !B) && B;
                    Console.WriteLine($"{A}\t{B}\t{res}");
                }

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}