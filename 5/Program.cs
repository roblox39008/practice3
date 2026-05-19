
namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C = double.Parse(Console.ReadLine());

            Console.Write("Введите число X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z = double.Parse(Console.ReadLine());

            bool a = A > 100 && B > 100;
            Console.WriteLine($"a) каждое из чисел A и B больше 100: {a}");

            bool b = A > 0 || B > 0;
            Console.WriteLine($"b) хотя бы одно из чисел A и B положительное: {b}");

            bool c = (A % 3 == 0) && (B % 3 == 0) && (C % 3 == 0);
            Console.WriteLine($"в) каждое из чисел A, B, C кратно трем: {c}");

            bool d = ((A < 50) ^ (B < 50) ^ (C < 50)) && !((A < 50) && (B < 50) && (C < 50)) && !((A < 50) && (B < 50)) && !((A < 50) && (C < 50)) && !((B < 50) && (C < 50));
            bool d_simple = (A < 50 && !(B < 50) && !(C < 50)) || (!(A < 50) && B < 50 && !(C < 50)) || (!(A < 50) && !(B < 50) && C < 50);
            Console.WriteLine($"г) только одно из чисел A, B, C меньше 50: {d_simple}");

            bool e = (A < 0) || (B < 0) || (C < 0);
            Console.WriteLine($"д) хотя бы одно из чисел A, B, C отрицательно: {e}");

            bool f = (X % 2 != 0) && (Y % 2 != 0);
            Console.WriteLine($"е) каждое из чисел X и Y нечетное: {f}");

            bool g = ((X < 20) ^ (Y < 20)) && !((X < 20) && (Y < 20));
            Console.WriteLine($"ж) только одно из чисел X и Y меньше 20: {g}");

            bool h = (X == 0) || (Y == 0);
            Console.WriteLine($"з) хотя бы одно из чисел X и Y равно нулю: {h}");

            bool i = (X < 0) && (Y < 0) && (Z < 0);
            Console.WriteLine($"и) каждое из чисел X, Y, Z отрицательное: {i}");

            bool j = ((X % 5 == 0) && (Y % 5 != 0) && (Z % 5 != 0)) ||
                     ((X % 5 != 0) && (Y % 5 == 0) && (Z % 5 != 0)) ||
                     ((X % 5 != 0) && (Y % 5 != 0) && (Z % 5 == 0));
            Console.WriteLine($"к) только одно из чисел X, Y, Z кратно пяти: {j}");

            bool k = (X > 100) || (Y > 100) || (Z > 100);
            Console.WriteLine($"л) хотя бы одно из чисел X, Y, Z больше 100: {k}");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
