using System;
using System.Collections.Generic;
using System.Text;

namespace c_advanced03
{
    public static class Helper
    {
        public static void PrintGrades(List<int> grades)
        {
            Console.WriteLine($"{string.Join(", ", grades)}");
        }

        public static void PrintSortedGrades(List<int> grades)
        {
            Console.WriteLine($"{string.Join(", ", grades)}");
        }

        public static void PrintFailedGrades(List<int> grades)
        {
            Console.WriteLine($"{string.Join(", ", grades)}");
        }


    }
}
