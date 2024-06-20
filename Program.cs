using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int degree1 = random.Next(1, 100);
            int degree = Convert.ToInt32(Console.ReadLine());

            int degreeBase = 2;
            int minDegree = 0;

            for (int i = degree; i <= degree; i++)
            {
                degreeBase *= degreeBase;
                Console.WriteLine(degreeBase);
            }
            Console.WriteLine(degree);
        }
    }
}
