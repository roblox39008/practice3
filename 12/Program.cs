
namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Расстояние в километрах: ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Расстояние в футах: ");
            double ft = double.Parse(Console.ReadLine());
            double kmInMeters = km * 1000;
            double ftInMeters = ft * 0.305;
            if (kmInMeters < ftInMeters)
                Console.WriteLine("Расстояние в километрах меньше");
            else if (ftInMeters < kmInMeters)
                Console.WriteLine("Расстояние в футах меньше");
            else
                Console.WriteLine("Расстояния равны");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}