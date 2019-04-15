using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightAndLengthConverter
{
    class Centimeter
    {
        public float LengthInCentimeters;

        public Centimeter(float lengthInCentimeters)
        {
            LengthInCentimeters = lengthInCentimeters;
        }
        public Centimeter()
        {
        }
        public float ConvertCentimetersToInches()
        {
            return (LengthInCentimeters * (0.39370f));
        }
        public float ConvertCentimetersToInches(float lengthInCentimeters)
        {
            LengthInCentimeters = lengthInCentimeters;
            return (lengthInCentimeters * (0.39370f));
        }
        public float ConvertCentimetersToFeets()
        {
            return (LengthInCentimeters * (0.032808f));
        }
        public string ConvertCentimetersToFeetsAndInches()
        {
            int howManyFeetsInLenght = (int)((LengthInCentimeters * (0.39370f)) / 12f);
            float howManyInchesLeft = ((LengthInCentimeters * (0.39370f)) % 12f);
            return (howManyFeetsInLenght.ToString() + " ft " + howManyInchesLeft.ToString() + " in");
        }
        public float ConvertCentimetersToFeets(float lengthInCentimeters)
        {
            LengthInCentimeters = lengthInCentimeters;
            return (lengthInCentimeters * (0.032808f));
        }
        public float ConvertCentimetersToInches(float lengthInCentimeters, out float inches)
        {
            LengthInCentimeters = lengthInCentimeters;
            return inches = (LengthInCentimeters * (0.39370f));
        }
    }
}
