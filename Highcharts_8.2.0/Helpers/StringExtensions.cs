using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Highcharts_8._2._0.Helpers
{
    public static class StringExtensions
    {
        public static int NextIndexOf(this string s, char search, int start)
        {
            while (start < s.Length && start >= 0)
            {
                if (s[start] == search)
                {
                    return start;
                }

                start++;
            }

            return -1;
        }
    }
}