using System.Runtime.InteropServices;

namespace uppgift7
{
    internal class Program : Geometri
    {
        static void Main()
        {
            Geometri geometri;

            // Skapa objekt och låt geometri peka på dem
            geometri = new Rektangel(3, 9);
            Console.WriteLine($"Area of the rectangle: {geometri.Area()}");

            geometri = new Fyrkant(8);
            Console.WriteLine($"Area of the square: {geometri.Area()}");

            geometri = new Parallellogram(2, 7);
            Console.WriteLine($"Area of the parallelogram: {geometri.Area()}");

            geometri = new Cirkel(6);
            Console.WriteLine($"Area of the circle: {geometri.Area()}");

            geometri = new Ellipse(5, 1);
            Console.WriteLine($"Area of the ellipse: {geometri.Area()}");
        }
    }
}