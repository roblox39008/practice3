
namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите k (1..365): ");
            int k = int.Parse(Console.ReadLine());
            int dayOfWeek = (k - 1) % 7;
            bool isWeekend = (dayOfWeek == 5) || (dayOfWeek == 6);
            Console.WriteLine($"День {k}: {(isWeekend ? "выходной" : "рабочий")}");

            Console.WriteLine("\nДва различных вещественных числа, найти max и min без полного условного оператора:");
            Console.Write("Введите первое число: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = double.Parse(Console.ReadLine());

            double max, min;
            // a) два неполных условных оператора
            max = x;
            if (y > max) max = y;
            min = x;
            if (y < min) min = y;
            Console.WriteLine($"a) Max = {max}, Min = {min}");

            // b) один неполный условный оператор
            double max2 = x;
            if (y > x) max2 = y;
            double min2 = x + y - max2;
            Console.WriteLine($"b) Max = {max2}, Min = {min2}");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}