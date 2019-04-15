using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightAndLengthConverter
{
    class Pound
    {
        public float WeightInLbs;
        public Pound(float weightInKg)
        {
            WeightInLbs = weightInKg;
        }
        public float ConvertLbsToKg()
        {
            return (WeightInLbs / 2.2046226218f);
        }
        public float ConvertLbsToKg(float weightInLbs)
        {
            WeightInLbs = weightInLbs;
            return (WeightInLbs / 2.2046226218f);
        }
    }
}
