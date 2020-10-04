using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SENG8040A1
{
    public class TriangleSolver
    {
        public void Analyze(int firstD, int secondD, int thirdD)
        {
            Console.WriteLine($"\nTriangle dimensions entered are {firstD}, {secondD}, and {thirdD}.");
            //int[] dimensions = { firstD, secondD, thirdD };

            if (firstD == secondD && firstD == thirdD)
            {
                Console.WriteLine($"This triangle is an equilateral.\n");
            }
            else if (firstD == secondD || firstD == thirdD || secondD == thirdD)
            {
                Console.WriteLine($"This triangle is an isosceles.\n");
            } 
            else
            {
                Console.WriteLine($"This triangle is a scalene.\n");
            }
        }
    }
}
