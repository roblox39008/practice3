
namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите четвёртое число: ");
            double d = double.Parse(Console.ReadLine());
            double max = Math.Max(a, Math.Max(b, Math.Max(c, d)));
            double min = Math.Min(a, Math.Min(b, Math.Min(c, d)));
            Console.WriteLine($"Наибольшее: {max}");
            Console.WriteLine($"Наименьшее: {min}");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}