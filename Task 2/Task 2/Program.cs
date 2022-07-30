using System;
using System.Collections.Generic;
using System.Linq;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double distance = 0;
            int n;
            var points = new Dictionary<object,double>();
            do
            {
                Console.WriteLine("Enter the number of points;");
                Console.WriteLine("The number of points has to be bigger than 1!");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 1);
            for(int i=0; i < n;)
            {
                GetCooddinats(ref x, ref y,ref distance);
                Point p1 = new Point(x, y);
                if (points.ContainsKey(p1))
                {
                    Console.WriteLine("This point has been added already");
                }
                else
                {
                points.Add(p1,distance);
                    i++;
                }
            }
            NearestPoints(points,n);
        }
        public static void GetCooddinats(ref double  x,ref double  y,ref double distance)
        {
            Console.WriteLine("Enter coordinates- x is:");
             x = double.Parse(Console.ReadLine());
             Console.WriteLine("y is:");
             y = double.Parse(Console.ReadLine());
            distance = Math.Sqrt(x * x + y + y);
        }
        public static void NearestPoints(Dictionary< object,double> points, int n)
        {
            int m = 0;
            while (true)
            {
                Console.WriteLine("Number of nearest points you want to see:");
                m = int.Parse(Console.ReadLine());
                if (m < n && m > 0)
                {
                    break;
                }
            }
                int a = 0;
            foreach (var item in points.OrderBy(value => value.Value))
            {
                if (a < m)
                {
                    Console.WriteLine(item);
                    a++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
