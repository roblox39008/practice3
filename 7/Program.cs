
namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x > 0)
                y = Math.Sin(x);
            else
                y = Math.Cos(x);
            Console.WriteLine($"y = {y}");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}