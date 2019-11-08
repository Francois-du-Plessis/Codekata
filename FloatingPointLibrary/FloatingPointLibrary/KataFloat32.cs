﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

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
            kataFloat = new KataFloat32();
            return false;

            // Find seperator
            var pattern = @"^(-{0,1})(\d+)\.{0,1}(\d*)$";
            var match = Regex.Match(number, pattern);

            if (match.Length == 0)
                return false;

            var sign = match.Groups[0].Value;
            kataFloat._sign = sign != "-" ? 0 : 1;

            //3.14                    #  
            //3/2 = 1.5     1         #     0.14 * 2 = 0.28     0     
            //1/2  = 0.5    1         #     0.28 * 2 = 0.56     0
            //0/2 = 0       0         #     0.56 * 2 = 1.12     1......
            //                        # 
            //11.001

            var intergralInput = match.Groups[1].Value;
            int.TryParse(intergralInput, out int intergral);

           // var a = GetIntergralBinary(intergral);

            var fractional = match.Groups[2].Value;
        }



        private static void GetIntergralBinary(int intergral)
        {
            //for each number divide by  2 and figure out if answer is whole or fraction ===> make 0 or 1 and concat to char array
            var result = intergral;  //1
            var mod = 0;
            var binary = new List<int>();

            do
            {
                mod = result % 2;   // 1 or 0
                result = result / 2;


            }
            while (!(mod == 0 && result == 0));
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