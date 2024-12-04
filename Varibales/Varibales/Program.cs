using System;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Varibales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            string s1 = "abc";

            //regular concatination
            string s2 = "def";
            string s3 = s1 +" " + s2;

            // String interpolation
            string s4 = $"{s1} {s2} ghi";


            //int limits

            //var
            var i = 0;
            var f = 0f;
            var d = 0d;
            var m = 0m;

            int million = 1_000_000;

            var r = 200 / 2.0;

            dynamic x;
            x = 10;
            x = "yes";


        }
    }
}
