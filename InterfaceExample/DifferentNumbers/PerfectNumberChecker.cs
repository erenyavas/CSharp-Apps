using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DifferentNumbers
{
    internal class PerfectNumberChecker : InterfaceNumberTypeChecker
    {
        public bool IsNumberType(int number)
        {
            if (number < 1) return false;

            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum == number;
        }

        public List<int> GetAllNumbersInRange(int start, int end)
        {
            var perfectNumbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsNumberType(i))
                    perfectNumbers.Add(i);
            }

            return perfectNumbers;
        }

        public List<int> GetFirst5Numbers()
        {
            var perfectNumbers = new List<int>();
            int count = 0;
            int number = 1;

            while (count < 5)
            {
                if (IsNumberType(number))
                {
                    perfectNumbers.Add(number);
                    count++;
                }
                number++;
            }

            return perfectNumbers;
        }
    }
}
