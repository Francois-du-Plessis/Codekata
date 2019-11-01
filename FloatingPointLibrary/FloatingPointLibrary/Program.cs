using System;

namespace FloatingPointLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var kata = new KataFloat32();

            float float1 = (float)(10 * Math.Exp(30));
            float float2 = (float)(9 * Math.Exp(16));
            float float3 = float1 + float2;

            int a= 1;
            int b= 10;
            var c = a / b;

            Console.WriteLine($"a | {a}");
            Console.WriteLine($"b | {b}");
            Console.WriteLine($"c | {c}");

            Console.WriteLine($"float1 == float3 | {float1 == float1}");
            Console.WriteLine($"float1 eqls float3 | {float1.Equals(float3)}");



            //Console.WriteLine($"{ZYX((object)kata)}");

            //int x = 1;
            //XYZ(kata);


            //Console.WriteLine($"{x}");
            Console.ReadLine();
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
