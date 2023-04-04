using Figgle;
using System;
using System.Numerics;

namespace StrongholdApproximator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2 t1p1;
            Vector2 t1p2;
            Vector2 t2p1;
            Vector2 t2p2;

            Logo();
            Console.WriteLine("Input first standing position X coordinate");
            t1p1.X = float.Parse(Console.ReadLine());
            Logo();
            Console.WriteLine("Input first standing position Z coordinate");
            t1p1.Y = float.Parse(Console.ReadLine());
            Logo();
            Console.WriteLine("Input first hover position X coordinate");
            t1p2.X = float.Parse(Console.ReadLine());
            Logo();
            Console.WriteLine("Input first hover position Z coordinate");
            t1p2.Y = float.Parse(Console.ReadLine());
            Logo();
            Console.WriteLine("Input second standing position X coordinate");
            t2p1.X = float.Parse(Console.ReadLine());
            Logo();
            Console.WriteLine("Input second standing position Z coordinate");
            t2p1.Y = float.Parse(Console.ReadLine());
            Logo();
            Console.WriteLine("Input second hover position X coordinate");
            t2p2.X = float.Parse(Console.ReadLine());
            Logo();
            Console.WriteLine("Input second hover position Z coordinate");
            t2p2.Y = float.Parse(Console.ReadLine());

            Logo();
            float A1 = t1p2.Y - t1p1.Y;
            float B1 = t1p1.X - t1p2.X;
            float C1 = A1 * t1p1.X + B1 * t1p1.Y;

            float A2 = t2p2.Y - t2p1.Y;
            float B2 = t2p1.X - t2p2.X;
            float C2 = A2 * t2p1.X + B2 * t2p1.Y;

            float d = A1 * B2 - A2 * B1;
            float x = (B2 * C1 - B1 * C2) / d;
            float y = (A1 * C2 - A2 * C1) / d;

            Vector2 intersect = new Vector2(x, y);

            Console.WriteLine(intersect);
        }
        private static void Logo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine(FiggleFonts.Big.Render("Lace's"));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Bedrock Stronghold Coordinates Approximation Tool");
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
        }
    }
}
