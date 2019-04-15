using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightAndLengthConverter
{
    class Feet//One Foot
    {
        public float LengthInFeets;

        public Feet(float lengthInFeets)
        {
            LengthInFeets = lengthInFeets;
        }
        public float ConvertFeetsToCentimeters()
        {
            return (LengthInFeets / (0.032808f));
        }
        public float ConvertFeetsToCentimeters(float lengthInFeets)
        {
            LengthInFeets = lengthInFeets;
            return (lengthInFeets / (0.032808f));
        }
        public float ConvertInchesToMeters()
        {
            float LengthInCentimeters = ConvertFeetsToCentimeters();
            return (LengthInCentimeters / 100);
        }
        public float ConvertInchesToMeters(float lengthInInches)
        {
            LengthInFeets = lengthInInches;
            float LengthInCentimeters = ConvertFeetsToCentimeters();
            return (LengthInCentimeters / 100);
        }
        public float ConvertFeetsToInches()
        {
            return (LengthInFeets / (0.083333f));
        }
        public float ConvertFeetsToInches(float lengthInFeets)
        {
            LengthInFeets = lengthInFeets;
            return (LengthInFeets / (0.083333f));
        }
    }
}
