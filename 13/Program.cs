
namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Скорость в км/ч: ");
            double kmh = double.Parse(Console.ReadLine());
            Console.Write("Скорость в м/с: ");
            double ms = double.Parse(Console.ReadLine());
            double kmhToMs = kmh / 3.6;
            if (kmhToMs > ms)
                Console.WriteLine("Скорость в км/ч больше");
            else if (ms > kmhToMs)
                Console.WriteLine("Скорость в м/с больше");
            else
                Console.WriteLine("Скорости равны");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}