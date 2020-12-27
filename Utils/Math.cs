using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerIncomeStats.Utils
{
    public static class Math
    {
        public static bool OnIntervalStrict(this int num, int a, int b)
            => num > a && num < b;
    }
}