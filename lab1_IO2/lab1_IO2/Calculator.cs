using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_IO2
{
    public static class Calculator
    {


        public static double Add(string s)
        {
            List<char> delimiterList = new List<char>() { ',', '\n' };
            if (s == null || s.Length == 0)
                return 0;
            if (s.StartsWith("\\\\"))
                delimiterList.Add(s[2]);
            //if (double.TryParse(s, out double d))
            //    return d;
            var split = s.Split(delimiterList.ToArray());
            //if (split.Length == 2)
            //    if (double.TryParse(split[0], out double d1) && double.TryParse(split[1], out double d2))
            //        return d1 + d2;
            double sum = 0;
            for (int i = 0; i < split.Length; i++)
            {
                if (double.TryParse(split[i], out double d))
                {
                    if (d < 0)
                        throw new ArgumentOutOfRangeException("Negative number detected");

                    if (d > 1000)
                        continue;
                    sum += d;
                }
                else
                    return sum;
            }
            return sum;
        }

    }
}
