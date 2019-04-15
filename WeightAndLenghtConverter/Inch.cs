using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightAndLengthConverter
{
    class Inch
    {
        public float LengthInInches;
        public Inch(float lengthInInches)
        {
            LengthInInches = lengthInInches;
        }
        public float ConvertInchesToCentimeters()
        {
            return (LengthInInches / (0.39370f));
        }
        public float ConvertInchesToCentimeters(float lengthInInches)
        {
            LengthInInches = lengthInInches;
            return (lengthInInches / (0.39370f));
        }
        public float ConvertInchesToMeters()
        {
            float LengthInCentimeters = ConvertInchesToCentimeters();
            return (LengthInCentimeters / 100);
        }
        public float ConvertInchesToMeters(float lengthInInches)
        {
            LengthInInches = lengthInInches;
            float LengthInCentimeters = ConvertInchesToCentimeters();
            return (LengthInCentimeters / 100);
        }
        public float ConvertInchesToFeets()
        {
            return (LengthInInches * (0.083333f));
        }
        public float ConvertInchesToFeets(float lengthInInches)
        {
            LengthInInches = lengthInInches;
            return (LengthInInches * (0.083333f));
        }
    }
}
