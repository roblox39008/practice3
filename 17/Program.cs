
namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый прямоугольник:");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("ширина w1 = ");
            double w1 = double.Parse(Console.ReadLine());
            Console.Write("высота h1 = ");
            double h1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Второй прямоугольник:");
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("ширина w2 = ");
            double w2 = double.Parse(Console.ReadLine());
            Console.Write("высота h2 = ");
            double h2 = double.Parse(Console.ReadLine());

            double x1r = x1 + w1;
            double y1r = y1 + h1;
            double x2r = x2 + w2;
            double y2r = y2 + h2;

            bool firstInsideSecond = (x1 >= x2) && (y1 >= y2) && (x1r <= x2r) && (y1r <= y2r);
            bool secondInsideFirst = (x2 >= x1) && (y2 >= y1) && (x2r <= x1r) && (y2r <= y1r);

            bool allPointsFirstInSecond = firstInsideSecond;
            bool allPointsOneInAnother = firstInsideSecond || secondInsideFirst;

            bool intersect = !((x1r < x2) || (x2r < x1) || (y1r < y2) || (y2r < y1));

            Console.WriteLine($"а) Все точки первого принадлежат второму: {allPointsFirstInSecond}");
            Console.WriteLine($"б) Все точки одного из прямоугольников принадлежат другому: {allPointsOneInAnother}");
            Console.WriteLine($"в) Прямоугольники пересекаются: {intersect}");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}