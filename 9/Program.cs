
namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            double max = a > b ? a : b;
            double min = a < b ? a : b;
            Console.WriteLine($"Максимальное: {max}");
            Console.WriteLine($"Минимальное: {min}");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}