
namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер года: ");
            int n = int.Parse(Console.ReadLine());
            bool isLeap = (n % 4 == 0) && (n % 100 != 0) || (n % 400 == 0);
            Console.WriteLine($"Год {n} високосный: {isLeap}");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}