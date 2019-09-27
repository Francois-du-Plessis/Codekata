using System;
using System.Collections.Generic;
using System.Text;

namespace FloatingPointLibrary
{
    public struct KataFloat32
    {
        internal int _sign;
        internal uint _exponent;
        internal uint _mantissa;

        public KataFloat32 Parse(string number)
        {
            KataFloat32.TryParse("asdasd", out var kataFloat, out _);
        }

        public static bool TryParse(string number, out KataFloat32 kataFloat, out bool isExact)
        {

        }

        public static bool TryParse(string number, out KataFloat32 kataFloat)
        {

        }

        public static KataFloat32 operator* (KataFloat32 x, KataFloat32 y)
        {
            return new KataFloat32();
        }

        // Assume no c# float
        // Implicity cast between integer and KataFloat32
        // Tell user if the we could parse their float exactly
        // Comparison between two floats (how accurate are we going to be)


        // Talk about this more
        // Think about our users
        //

    }
}
