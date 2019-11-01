using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FloatingPointLibrary.Unit.Test")]
namespace FloatingPointLibrary
{
    /// <summary>
    /// This is a float, my float is amazing.
    /// </summary>
    public struct KataFloat32
    {
        internal int _sign;
        internal uint _exponent;
        internal uint _mantissa;

        public override string ToString()
        {
            return "Hello I am a Katafloat";
        }

        public static bool TryParse(string number, out KataFloat32 kataFloat)
        {
            // Find sperator
            // ^(-{ 0,1})((\d +)\.{ 0,1} (\d *))$
        }

        //public KataFloat32 Parse(string number)
        //{
        //    KataFloat32.TryParse("asdasd", out var kataFloat, out _);
        //}

        //public static bool TryParse(string number, out KataFloat32 kataFloat, out bool isExact)
        //{
        //    throw new NotImplementedException();
        //    return true;
        //}

        //public bool Equals(KataFloat32 b)
        //{
        //    return base.Equals(obj);
        //}

        //public static KataFloat32 operator* (KataFloat32 x, KataFloat32 y)
        //{
        //    return new KataFloat32();
        //}

        //public static KataFloat32 operator== (KataFloat32 x, KataFloat32 y)
        //{
        //    return new KataFloat32();
        //}

        //public static KataFloat32 operator!= (KataFloat32 x, KataFloat32 y)
        //{
        //    return new KataFloat32();
        //}

        // Assume no c# float
        // Implicity cast between integer and KataFloat32
        // Tell user if the we could parse their float exactly
        // Comparison between two floats (how accurate are we going to be)
        //     - Implement c# standard interfaces like IComparison 
        // == vs Equals 
        // - Do both, be able to specify precision with Equals method 
        //    == will use default precision defined as a static value that the user can set

        // Talk about this more
        // Think about our users
        //

    }
}
