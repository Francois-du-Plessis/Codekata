using System;

namespace FloatingPointLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            KataFloat32 kata = new KataFloat32();
            kata._sign = 5;

            int x = 1;
            XYZ(kata);


            Console.WriteLine($"{x}");
            Console.ReadLine();
        }

        public static void XYZ(KataFloat32 x)
        {
            x = new KataFloat32();
            x._sign = 4;
        }
    }
}
