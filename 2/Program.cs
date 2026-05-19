
namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] values = { false, true };
            Console.WriteLine("Задание 2а: !(A || !B && C)");
            Console.WriteLine("A\tB\tC\tResult");
            foreach (bool A in values)
                foreach (bool B in values)
                    foreach (bool C in values)
                    {
                        bool res = !(A || !B && C);
                        Console.WriteLine($"{A}\t{B}\t{C}\t{res}");
                    }

            Console.WriteLine("\nЗадание 2б: A && !(B && A || !C)");
            Console.WriteLine("A\tB\tC\tResult");
            foreach (bool A in values)
                foreach (bool B in values)
                    foreach (bool C in values)
                    {
                        bool res = A && !(B && A || !C);
                        Console.WriteLine($"{A}\t{B}\t{C}\t{res}");
                    }

            Console.WriteLine("\nЗадание 2в: !(!A || B && C)");
            Console.WriteLine("A\tB\tC\tResult");
            foreach (bool A in values)
                foreach (bool B in values)
                    foreach (bool C in values)
                    {
                        bool res = !(!A || B && C);
                        Console.WriteLine($"{A}\t{B}\t{C}\t{res}");
                    }

            Console.WriteLine("\nЗадание 2г: !(A || !B && C) || C");
            Console.WriteLine("A\tB\tC\tResult");
            foreach (bool A in values)
                foreach (bool B in values)
                    foreach (bool C in values)
                    {
                        bool res = !(A || !B && C) || C;
                        Console.WriteLine($"{A}\t{B}\t{C}\t{res}");
                    }

            Console.WriteLine("\nЗадание 2д: !(A && !B || C) && B");
            Console.WriteLine("A\tB\tC\tResult");
            foreach (bool A in values)
                foreach (bool B in values)
                    foreach (bool C in values)
                    {
                        bool res = !(A && !B || C) && B;
                        Console.WriteLine($"{A}\t{B}\t{C}\t{res}");
                    }

            Console.WriteLine("\nЗадание 2е: !(!A || B && C) || A");
            Console.WriteLine("A\tB\tC\tResult");
            foreach (bool A in values)
                foreach (bool B in values)
                    foreach (bool C in values)
                    {
                        bool res = !(!A || B && C) || A;
                        Console.WriteLine($"{A}\t{B}\t{C}\t{res}");
                    }

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}