using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР8_ИДЗ
{
    internal class Уравнение
    {
        public static double Решить1(double x, double y, int n)
        {
            double result = 0;
            double chisl = 0;
            for (int i = 1; i <= n; i++)
            {
                double znam = 2;
                if (i != 1)
                {
                    znam = znam * (i + 2);
                }
                if (i % 2 == 0)
                    chisl = chisl + (Math.Pow(y, (i)));
                else
                    chisl = chisl - (Math.Pow(x, (i)));
                result += chisl / znam;
                chisl = 0;
            }
            return result;
        }

        public static double Решить2(int n, int r)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; i <= r; i++)
                {
                    result += (3+j) / (i);
                }
            }
            return result;
        }
    }
}
