using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAccounting.Business
{
    public static class ChartFill
    {
        public static double AvgCalc(List<double> values) => (values.Sum() / values.Count);
    }
}
