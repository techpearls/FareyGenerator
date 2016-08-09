using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareyGeneratorLib
{
    public static class FareyGenerator
    {
        public static List<string> Generate(int n)
        {
            if (n < 1)
                return new List<string>(){"0"};
            var result = new List<string>();

            double x1 = 0, x2 = 1, y1 = 1, y2 = n;
            result.Add(x1.ToString() + "/" + y1.ToString());
            result.Add(x2.ToString() + "/" + y2.ToString());

            double x = 0, y = 0;

            while(y != 1)
            {
                x = Math.Floor((y1 + n) / y2) * x2 - x1;
                y = Math.Floor((y1 + n) / y2) * y2 - y1;
                result.Add(x.ToString() + "/" + y.ToString());
                x1 = x2;
                x2 = x;
                y1 = y2;
                y2 = y;
            }
            return result;
        }
    }
}
