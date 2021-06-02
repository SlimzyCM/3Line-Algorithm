using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Line_Algorithm_Test
{
    public static class Challenge
    {
        public static int SmallestPositiveNumber(int[] nums)
        {
            var sortedVal = nums.Where(x => x >= 1).OrderBy(x => x).ToHashSet();

            //var sortedVal = nums.Where(x => x >= 1).Distinct().OrderBy(x => x).ToList(); // Removed this due to Time and memory space efficiency

            var start = 1;
            foreach (var ele in sortedVal)
            {
                if (ele != start)
                {
                    return start;
                }

                start++;
            }
            return start;
        }
    }
}
