using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = 0;
            double []randArrayX = new double [n];
            double[] randArrayY = new double [n];
            Thread.Sleep(1);
            Random autoRand = new Random();
            
            for (int i = 0; i < n; i++)
            {
                randArrayX[i] = autoRand.NextDouble();
                randArrayY[i] = autoRand.NextDouble();
                if ((randArrayX[i] - 0.5) * (randArrayX[i] - 0.5)
                   + (randArrayY[i] - 0.5) * (randArrayY[i] - 0.5) <= 0.25)
                {
                    m++;
                }
            }
            Console.Write("PI = ");
            Console.WriteLine("{0:F6}", Convert.ToDouble(4 * m)/Convert.ToDouble(n));

        }
    }
}
