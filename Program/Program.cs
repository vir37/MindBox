using FigureArea;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>()
            {
                new Circle(0),
                new Triangle(10,11,12)
            };

            foreach (var f in figures)
            {
                Console.WriteLine($"{f.Name}: площадь - {f.GetArea()}");
            }
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
