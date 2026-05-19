
namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Длина стола a (целое, a > b): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ширина стола b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Длина прямоугольника c (c > d): ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Ширина прямоугольника d: ");
            int d = int.Parse(Console.ReadLine());

            int alongLong = (a / c) * (b / d);
            int alongShort = (a / d) * (b / c);
            Console.WriteLine($"При размещении вдоль длинной стороны: {alongLong} шт.");
            Console.WriteLine($"При размещении вдоль короткой стороны: {alongShort} шт.");
            if (alongLong > alongShort)
                Console.WriteLine("Лучше размещать вдоль длинной стороны стола");
            else if (alongShort > alongLong)
                Console.WriteLine("Лучше размещать вдоль короткой стороны стола");
            else
                Console.WriteLine("Оба способа дают одинаковое количество");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}