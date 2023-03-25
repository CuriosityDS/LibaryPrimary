using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointLibary;
namespace LibaryPrimary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(6, 6);
            Point point2 = new Point(12,6);
            Point point3 = new Point(12, 1);
            Point point4 = new Point(1, 12);
            Rectangle point = new Rectangle(point1, point2, point3, point4);
            Console.WriteLine(point);
            Parallelogramm parallelogramm = new Parallelogramm(point1, point2, point3, point4);
            Console.WriteLine(parallelogramm);
            Rhomb rhomb = new Rhomb(point1, point2, point3, point4);
            Console.WriteLine(rhomb);
            Squar squar = new Squar(point1, point2, point3, point4);
            Console.WriteLine(squar);
            Console.ReadKey();
        }
    }
}
