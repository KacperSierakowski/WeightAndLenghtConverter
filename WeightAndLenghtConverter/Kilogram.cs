using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightAndLengthConverter
{
    class Kilogram
    {
        public float WeightInKg;
        public Kilogram(float weightInKg)
        {
            WeightInKg = weightInKg;
        }
        public float ConvertKilogramsToLbs()
        {
            return (WeightInKg * 2.2046226218f);
        }
        public float ConvertKgToLbs(float weightInKg)
        {
            WeightInKg = weightInKg;
            return (WeightInKg * 2.2046226218f);
        }
    }
}
