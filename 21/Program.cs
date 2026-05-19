
namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите время в минутах с начала часа: ");
            double t = double.Parse(Console.ReadLine());
            int period = 5; // 3 мин зеленый + 2 мин красный
            double mod = t % period;
            string color;
            if (mod < 3)
                color = "зеленый";
            else
                color = "красный";
            Console.WriteLine($"Горит {color} сигнал");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}