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
            int lowLimitRandom = 1;
            int highLimitRandom = 1000;

            Random random = new Random();
            int number = random.Next(lowLimitRandom, highLimitRandom);

            Console.WriteLine($"Загаданное число: {number}");

            int degreeBase = 2;
            int degree = 1;
            int baseInDegree = degreeBase;

            while (baseInDegree <= number)
            {
                baseInDegree *= degreeBase;
                degree++;
            }

            Console.WriteLine($"{degreeBase} в степени {degree} равняется {baseInDegree} > {number}");
        }
    }
}
