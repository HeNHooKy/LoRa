using GreenhouseMeter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenhouseMeter
{
    /// <summary>
    /// Принимает данные в виде массива троек x, y, value и, используя формулу Лагранжа, строит карту распределения
    /// </summary>
    public static class MathController
    {
        /// <summary>
        /// Построение карты распределения по данным
        /// </summary>
        /// <param name="datas">массив троек x, y, value</param>
        /// <param name="step">шаг между предыдущим и следующим значением</param>
        /// <returns>карта распределения</returns>
        public static double[,] BuildDistribution(IEnumerable<Point> datas, double step)
        {
            double maxX = double.MinValue;
            double minX = double.MaxValue;
            double maxY = double.MinValue;
            double minY = double.MaxValue;
            var values = datas.ToArray();

            for(int i = 0; i < values.Length; i++)
            {
                maxX = Math.Max(values[i].X, maxX);
                minX = Math.Min(values[i].X, minX);
                maxY = Math.Max(values[i].Y, maxY);
                minY = Math.Min(values[i].Y, minY);
            }

            int width = (int)((maxY - minY) / step);
            int height = (int)((maxX - minX) / step);

            var result = new double[height + 1, width + 1];

            if (width == 0 || height == 0)
            {
                return result;
            }

                double fixedX = minX;
            for(int i = 1; i < height + 1; i++)
            {
                result[i, 0] = fixedX;
                fixedX += step;
            }

            double fixedY = minY;
            for(int i = 1; i < width + 1; i++)
            {
                result[0, i] = fixedY;
                fixedY += step;
            }

            var F = GetF(values);

            for (int i = 1; i < height + 1; i++)
            {
                for (int j = 1; j < width + 1; j++)
                {
                    double x = result[i, 0];
                    double y = result[0, j];

                    result[i, j] = GetSolution(F, x, y);
                }
            }

            return result;
        }

        private static Point[,] GetF(IEnumerable<Point> values)
        {
            double count = values.Count();

            int N = (int)Math.Sqrt(count);

            if(count % N != 0)
            {
                throw new Exception("Не удалось построить квадратную матрицу N*N - количество датчиков должно быть кратно их корню");
            }

            var listValues = values.ToList();
            listValues.Sort((a, b) => a.Num > b.Num ? 1 : -1);

            var F = new Point[N, N];

            for(int i = 0; i < count; i++)
            {
                int j = i / N;
                var point = listValues[i];
                F[i % N, j] = point;
            }

            return F;
        }

        private static double GetSolution(Point[,] F, double x, double y)
        {
            double result = 0;

            int N = F.GetLength(0);
            int M = F.GetLength(1);

            for(int n = 0; n < N; n++)
            {
                for(int m = 0; m < M; m++)
                {
                    result += F[n, m].Value * GetL(F, n, m, x, y);
                }
            }

        }

        private static double GetL(Point[,] F, int n, int m, double x, double y)
        {
            int N = F.GetLength(0);
            int M = F.GetLength(1);

            double result = 1;

            for(int i = 0; i < N; i++)
            {
                if(i == n)
                {
                    continue;
                }

                for(int j = 0; j < M; j++)
                {
                    if(j == m)
                    {
                        continue;
                    }

                    result *= ((x - F[))
                }
            }

            return result;
        }


    }
}
