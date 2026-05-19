
namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] values = { false, true };
            Console.WriteLine("Задание 3а: (X || Y) → (Y == X)  (импликация)");
            Console.WriteLine("X\tY\tZ\tResult");
            foreach (bool X in values)
                foreach (bool Y in values)
                    foreach (bool Z in values)
                    {
                        bool impl = !(X || Y) || (Y == X);
                        Console.WriteLine($"{X}\t{Y}\t{Z}\t{impl}");
                    }

            Console.WriteLine("\nЗадание 3б: (X || Y) == (Y && X)");
            Console.WriteLine("X\tY\tZ\tResult");
            foreach (bool X in values)
                foreach (bool Y in values)
                    foreach (bool Z in values)
                    {
                        bool res = (X || Y) == (Y && X);
                        Console.WriteLine($"{X}\t{Y}\t{Z}\t{res}");
                    }

            Console.WriteLine("\nЗадание 3в: (X && Y) || (Y → X)");
            Console.WriteLine("X\tY\tZ\tResult");
            foreach (bool X in values)
                foreach (bool Y in values)
                    foreach (bool Z in values)
                    {
                        bool impl = !Y || X;
                        bool res = (X && Y) || impl;
                        Console.WriteLine($"{X}\t{Y}\t{Z}\t{res}");
                    }

            Console.WriteLine("\nЗадание 3г: (X == Y) → Y");
            Console.WriteLine("X\tY\tZ\tResult");
            foreach (bool X in values)
                foreach (bool Y in values)
                    foreach (bool Z in values)
                    {
                        bool impl = !(X == Y) || Y;
                        Console.WriteLine($"{X}\t{Y}\t{Z}\t{impl}");
                    }

            Console.WriteLine("\nЗадание 3д: (X || Y) → (Z == X)");
            Console.WriteLine("X\tY\tZ\tResult");
            foreach (bool X in values)
                foreach (bool Y in values)
                    foreach (bool Z in values)
                    {
                        bool impl = !(X || Y) || (Z == X);
                        Console.WriteLine($"{X}\t{Y}\t{Z}\t{impl}");
                    }

            Console.WriteLine("\nЗадание 3е: (X == (Z || Y)) || ((X → Z) && (Y → X))");
            Console.WriteLine("X\tY\tZ\tResult");
            foreach (bool X in values)
                foreach (bool Y in values)
                    foreach (bool Z in values)
                    {
                        bool left = X == (Z || Y);
                        bool impl1 = !X || Z;
                        bool impl2 = !Y || X;
                        bool right = impl1 && impl2;
                        bool res = left || right;
                        Console.WriteLine($"{X}\t{Y}\t{Z}\t{res}");
                    }

            Console.WriteLine("\nЗадание 3ж: Y → (Z == X)");
            Console.WriteLine("X\tY\tZ\tResult");
            foreach (bool X in values)
                foreach (bool Y in values)
                    foreach (bool Z in values)
                    {
                        bool impl = !Y || (Z == X);
                        Console.WriteLine($"{X}\t{Y}\t{Z}\t{impl}");
                    }

            Console.WriteLine("\nЗадание 3з: X == (Y → Z)");
            Console.WriteLine("X\tY\tZ\tResult");
            foreach (bool X in values)
                foreach (bool Y in values)
                    foreach (bool Z in values)
                    {
                        bool impl = !Y || Z;
                        bool res = X == impl;
                        Console.WriteLine($"{X}\t{Y}\t{Z}\t{res}");
                    }

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}