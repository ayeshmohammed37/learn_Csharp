using System;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Varibales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region varibles

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
            #endregion


            //working with bools
            bool b1 = true;
            bool b2 = false;
            int i1 = 2;
            int i2 = 3;
            bool b3 = i1 == i2;      

            var c1 = i1 <= i2;
            var c2 = i1 >= i2;

            var n = !b1;

            // logical operators
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ true);
            Console.WriteLine(false ^ false);


            // short circuit
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            // logical opertator
            Console.WriteLine(true & true);
            Console.WriteLine(true & false);
            Console.WriteLine(false & true);
            Console.WriteLine(false & false);

            int a1 = 5;
            int a2 = 5;
            Console.WriteLine(a1 == a2);

            string str1 = "hello";
            string str2 = "hello";

            Console.WriteLine(str1 == str2);

            int total = 100;
            int unit = 500;

            var res = total >= unit ? "done" : "not done";
            Console.WriteLine(res);


        }
    }
}
