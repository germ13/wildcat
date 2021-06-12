using System;
using System.Collections.Generic;
using System.Linq;

namespace Wildcat.Utilities
{
    public static class MathHelper
    {
        //MOVE TO UTILS
        public static double CalculateStandardDeviation(IEnumerable<double> values)
        {
            double ret = 0d;

            if (values.Count() > 0)
            {
                double avg = values.Average();

                double sum = values.Sum(d => Math.Pow(d - avg, 2));

                ret = Math.Sqrt((sum) / (values.Count() - 1));
            }

            return ret;
        }
    }
}
