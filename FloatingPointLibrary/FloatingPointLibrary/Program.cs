using System;
using System.Collections.Generic;

namespace FloatingPointLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            GetIntergralBinary(0);
            
            //Console.WriteLine($"{ZYX((object)kata)}");

            //int x = 1;
            //XYZ(kata);


            //Console.WriteLine($"{x}");
            Console.ReadLine();
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

                Console.WriteLine("MOD ="+ mod);
                Console.WriteLine("RESULT =" + result);

            }
            while (!(mod == 0 && result == 0));
        }


        public static void XYZ(KataFloat32 x)
        {
            x = new KataFloat32();
            x._sign = 4;
        }

        public static string ZYX(KataFloat32 x)
        {
            Console.WriteLine($"I are the bestest katafloat");
            return x.ToString();
        }

        public static string ZYX(object x)
        {
            Console.WriteLine($"I are a dumb ojeakt");
            return x.ToString();
        }
    }
}
