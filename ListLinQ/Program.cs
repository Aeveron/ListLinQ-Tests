
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ListLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            //Test2();
            //TestLINQ();
            TestString();
        }

        private static void TestString()
        {
            var text = "xxxxASDFxxxxx;24xx;xxxx23542;xxxxxxnei;xxxxxhei;";
            var parts = text.Split(';');
            foreach (var part in parts)
            {
                Console.WriteLine(part.Trim('x'));
            }
        }

        private static void TestLINQ()
        {
            var list = GetPoints();
            //var point = list.FirstOrDefault(p => p.X == p.Y);
            //Console.WriteLine(point == null ? "null" : point.ToString());

            var points = list.Where(p => p.X == p.Y);
            foreach (var p in points)
            {
                Console.WriteLine(p);
            }

            if (list.Any(p => p.X == p.Y)) { }
            if (list.Any(p => p.X == p.Y)) { }
            {
                
            }
        }


        private static void Test()
        {
            //int[] list = new int[10];
            var list = new List<int>();
            var random = new Random();
            var count = 0;
            while (true)
            {
                var number = random.Next(0, 100);
                list.Add(number);
                count++;
                if (random.Next(0, 10) == 5) break;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
            }

            Console.WriteLine();

            foreach (var number in list)
            {
                Console.WriteLine(number + " ");
            }

            Console.WriteLine();
        }

        private static void Test2()
        {
            //int[] list = new int[10];
            var list = GetPoints();

            foreach (var point in list)
            {
                Console.WriteLine(point + " ");
            }

            Console.WriteLine();
        }

        private static List<Point> GetPoints()
        {
            var list = new List<Point>();
            var random = new Random();
            var count = 0;
            while (true)
            {
                var point = new Point(random.Next(0, 10), random.Next(0, 10));
                list.Add(point);
                count++;
                if (random.Next(0, 10) == 5) break;
            }

            return list;
        }
    }
}
