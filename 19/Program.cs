
namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Длина стола a (целое, a > b): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ширина стола b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Размер кости c (c > d > e): ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Размер кости d: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Размер кости e: ");
            int e = int.Parse(Console.ReadLine());

            int maxCount = 0;
            string bestFace = "";

            int[,] faces = { { c, d }, { c, e }, { d, e } };
            string[] faceNames = { "c×d", "c×e", "d×e" };

            for (int i = 0; i < 3; i++)
            {
                int side1 = faces[i, 0];
                int side2 = faces[i, 1];
                int count1 = (a / side1) * (b / side2);
                int count2 = (a / side2) * (b / side1);
                int count = Math.Max(count1, count2);
                if (count > maxCount)
                {
                    maxCount = count;
                    bestFace = faceNames[i];
                }
            }

            Console.WriteLine($"Максимальное количество костей: {maxCount}");
            Console.WriteLine($"Используемая грань: {bestFace}");
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}