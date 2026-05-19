
namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 10;
            bool endsEven = (lastDigit % 2 == 0);
            bool endsOdd = (lastDigit % 2 != 0);
            Console.WriteLine($"а) Заканчивается чётной цифрой: {endsEven}");
            Console.WriteLine($"б) Заканчивается нечётной цифрой: {endsOdd}");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}