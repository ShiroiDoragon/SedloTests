using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedloTests
{
    public class Program
    {
        public static void Main()
        {
            int[,] Matr; // {{1,2,3},{4,5,6},{7,8,9}};
            Console.WriteLine("Введите размер массива ");
            int r = 0;
            int.TryParse(Console.ReadLine(), out r);
            Matr = new int[r, r];
            Console.WriteLine("Введите матрицу");
            for(int i=0; i<r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Matr[i, j] = 0;
                    int.TryParse(Console.ReadLine(), out Matr[i,j]);
                }
            }

            Sedlo sedlo = new Sedlo(Matr);
            var points = sedlo.SedloPoints;
            foreach (var p in points)
            {
                Console.Write(p.CoordX + " " + p.CoordY + " " + p.Value + "; ");
            }
            //testMethod();
            Console.ReadLine();
        }


        static void testMethod()
        {
            int[,] Matr = new int[,] {{1,2,3},{4,5,6},{7,8,9}};
            Sedlo sedlo = new Sedlo(Matr);
            List<Point> goodPoints = new List<Point>();
            goodPoints.Add(new Point(0, 2, 3));
            goodPoints.Add(new Point(2, 0, 7));
            var goodhash = goodPoints.Select(item => item.HashPoint).ToArray();
            Array.Sort(goodhash);

            var badhash = sedlo.SedloPoints.Select(item => item.HashPoint).ToArray();
            Array.Sort(badhash);

            Console.WriteLine("badhash: " + (badhash));
            Console.WriteLine("goodhash: " + (goodhash));
            Console.WriteLine("compare: " + (badhash.SequenceEqual(goodhash)));
        }
    }
}


