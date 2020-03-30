using System;
using System.Collections.Generic;

namespace FilteringV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> values = new List<int>() {12, 24, 9, 10, 6, 3, 45};
            List<int> filteredValues2 = Filter.FilterValues(values);

            foreach (var value in filteredValues2)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}