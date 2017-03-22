using System;

namespace WebApplication5
{
    public static class PageEventsAndManageElements
    {
        public static string QuadraticEquation(string a, string b, string c)
        {
            int A;
            int B;
            int C;
            Int32.TryParse(a, out A);
            if (A == 0) return "a can't be a zero";
            Int32.TryParse(b, out B);
            Int32.TryParse(c, out C);
            double D = Discrimenant(A, B, C);

            if (D < 0)
            {
                string res1 = ((-B + Math.Sqrt(Math.Abs(D))) / 2 * A).ToString();
                string res2 = ((-B - Math.Sqrt(Math.Abs(D))) / 2 * A).ToString();
                return "D= " + D.ToString() + ", x1 = " + res1 + ", x2= " + res2;
            }

            else if (D > 0)
            {
                string res1 = ((-B + Math.Sqrt(D)) / 2 * A).ToString();
                string res2 = ((-B - Math.Sqrt(D)) / 2 * A).ToString();

                return "D= "+ D.ToString() +", x1 = " + res1 + ", x2= " + res2;
            }

            else
            {
                string res1 = ((-B) / 2 * A).ToString();
                string res2 = res1;
                return "D= " + D.ToString() + ", x1 = " + res1 + ", x2= " + res2;
            }
        }

        public static double Discrimenant(int A, int B, int C)
        {
            return Math.Pow(B, 2) - 4 * A * C;
        }
    }
}