using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedloTests
{
    public class Sedlo
    {
        int[,] Matr;
        public List<Point> sedloPoints = new List<Point>();
        public Sedlo(int[,] Matr)
        {
            this.Matr = Matr;
            var maxPoints = Max('r');
            var minPoints = Min('c');

            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    if (Matr[i, j] == maxPoints[i] && Matr[i, j] == minPoints[j])
                        SedloPoints.Add(new Point(i, j, Matr[i, j]));
                }
            }

            maxPoints = Max('c');
            minPoints = Min('r');
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    if (Matr[i, j] == maxPoints[j] && Matr[i, j] == minPoints[i])
                        SedloPoints.Add(new Point(i, j, Matr[i, j]));
                }
            }
        }
        public int[] Max(char ch)
        {
            int maxValue = 0;
            int[] matrMax;
            if (ch == 'r')
                matrMax = new int[Matr.GetLength(0)];
            else
                matrMax = new int[Matr.GetLength(1)];
            switch (ch)
            {
                case 'r':
                    {
                        for (int i = 0; i < Matr.GetLength(0); i++)
                        {
                            maxValue = Matr[i, 0];
                            for (int j = 0; j < Matr.GetLength(1); j++)
                                if (maxValue < Matr[i, j])
                                    maxValue = Matr[i, j];
                            matrMax[i] = maxValue;
                        }
                    }
                    break;
                case 'c':
                    {
                        for (int i = 0; i < Matr.GetLength(1); i++)
                        {
                            maxValue = Matr[0, i];
                            for (int j = 0; j < Matr.GetLength(0); j++)
                                if (maxValue < Matr[j, i])
                                    maxValue = Matr[j, i];
                            matrMax[i] = maxValue;
                        }
                    }
                    break;
            }
                return matrMax;
        }
        public int[] Min(char ch)
        {
            int minValue = 0;
            int[] matrMin;
            if (ch == 'r')
                matrMin = new int[Matr.GetLength(0)];
            else
                matrMin = new int[Matr.GetLength(1)];
            switch (ch)
            {
                case 'r':
                    {
                        for (int i = 0; i < Matr.GetLength(0); i++)
                        {
                            minValue = Matr[i, 0];
                            for (int j = 0; j < Matr.GetLength(1); j++)
                                if (minValue > Matr[i, j])
                                    minValue = Matr[i, j];
                            matrMin[i] = minValue;
                        }
                    }
                    break;
                case 'c':
                    {
                        for (int i = 0; i < Matr.GetLength(1); i++)
                        {
                            minValue = Matr[0, i];
                            for (int j = 0; j < Matr.GetLength(0); j++)
                                if (minValue > Matr[i, j])
                                    minValue = Matr[i, j];
                            matrMin[i] = minValue;
                        }
                    }
                    break;
            }
            return matrMin;
        }

        public List<Point> SedloPoints
        {
            get { return sedloPoints; }
            private set { sedloPoints = value; }
        }
    }
}




