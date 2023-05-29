using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    internal class anonymousExample
    {
        Func<Func<int>[], double> AvgMethod = (Func<int>[] a) =>
        {
            double res = 0;
            foreach (var x in a)
            {
                res += x.Invoke();
            }
            return res / a.Length;
        };

    }
}
