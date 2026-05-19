
namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"Большее: {a}");
                Console.WriteLine($"Меньшее: {b}");
            }
            else
            {
                Console.WriteLine($"Большее: {b}");
                Console.WriteLine($"Меньшее: {a}");
            }
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}