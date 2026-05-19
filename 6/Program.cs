
namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите целое N: ");
            int N = int.Parse(Console.ReadLine());

            bool a = (A % 2 == 0) || (A % 3 == 0);
            Console.WriteLine($"a) целое A кратно двум или трём: {a}");

            bool b = (N % 3 == 0) && (N % 10 == 0);
            Console.WriteLine($"б) целое N кратно трём и оканчивается нулем: {b}");

            bool c = (N % 5 == 0) || (N % 7 == 0);
            Console.WriteLine($"в) целое N кратно пяти или семи: {c}");

            bool d = (N % 4 == 0) && (N % 10 != 0);
            Console.WriteLine($"г) целое N кратно четырём и не оканчивается нулем: {d}");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}