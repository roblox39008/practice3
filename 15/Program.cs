
namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата: ");
            double a = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * r * r;
            double squareArea = a * a;
            if (circleArea > squareArea)
                Console.WriteLine("Площадь круга больше");
            else if (squareArea > circleArea)
                Console.WriteLine("Площадь квадрата больше");
            else
                Console.WriteLine("Площади равны");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}