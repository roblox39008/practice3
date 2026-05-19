
namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = double.Parse(Console.ReadLine());

            bool a = x < 2 && y < 3;
            Console.WriteLine($"а) x < 2 и y < 3 = {a}");

            bool b = !(x < 2);
            Console.WriteLine($"б) неверно, что x < 2 = {b}");

            bool c = x < 1 || y < 2;
            Console.WriteLine($"в) x < 1 или y < 2 = {c}");

            bool d = !(x < 0 && x < 5);
            Console.WriteLine($"г) неверно, что (x < 0 и x < 5) = {d}");

            bool e = x < 0 && y > 5;
            Console.WriteLine($"д) x < 0 и y > 5 = {e}");

            bool f = x > 10 && x < 20;
            Console.WriteLine($"е) 10 < x < 20 = {f}");

            bool g = x > 3 || x < 1;
            Console.WriteLine($"ж) x > 3 или x < 1 = {g}");

            bool h = y > 0 && y < 4 && x < 5;
            Console.WriteLine($"з) 0 < y < 4 и x < 5 = {h}");

            bool i = x > 3 && x < 10;
            Console.WriteLine($"и) x > 3 и x < 10 = {i}");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}