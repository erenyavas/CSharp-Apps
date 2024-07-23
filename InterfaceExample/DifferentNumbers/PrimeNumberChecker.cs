using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DifferentNumbers
{
    internal class PrimeNumberChecker : InterfaceNumberTypeChecker
    {
        public bool IsNumberType(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public List<int> GetAllNumbersInRange(int start, int end)
        {
            var primeNumbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsNumberType(i))
                    primeNumbers.Add(i);
            }

            return primeNumbers;
        }

        public List<int> GetFirst5Numbers()
        {
            var primeNumbers = new List<int>();
            int count = 0;
            int number = 2;

            while (count < 5)
            {
                if (IsNumberType(number))
                {
                    primeNumbers.Add(number);
                    count++;
                }
                number++;
            }

            return primeNumbers;
        }
    }
}
