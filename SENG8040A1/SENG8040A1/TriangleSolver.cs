namespace SENG8040A1
{
    public static class TriangleSolver
    {
        private static string triangle;

        public static string Analyze(int firstSide, int secondSide, int thirdSide)
        {
            string result = "";

            if (firstSide > 0 && secondSide > 0 && thirdSide > 0)
            {
                if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)
                {
                    if (firstSide == secondSide && firstSide == thirdSide)
                    {
                        triangle = "an equilateral";
                    }
                    else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
                    {
                        triangle = "an isosceles";
                    }
                    else
                    {
                        triangle = "a scalene";
                    }
                    result = $"The valid triangle as {triangle}";
                }
                else
                {
                    result = "The invalid triangle";
                }
            }
            else
            {
                result = "The invalid triangle";
            }

            return result;
        }
    }
}
