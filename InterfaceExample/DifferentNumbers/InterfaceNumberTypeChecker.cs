using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DifferentNumbers
{
    internal interface InterfaceNumberTypeChecker
    {
        bool IsNumberType(int number);
        List<int> GetAllNumbersInRange(int start, int end);
        List<int> GetFirst5Numbers();
    }
}
