using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareyGeneratorLib
{
    public static class FareyGenerator
    {
        public static string[] Generate(int n)
        {
            if (n < 1)
                return new string[] { "0" };
            return new string[] { "-1" }; //Dummy value
        }
    }
}
