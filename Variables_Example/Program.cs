using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm working");
            byte b1 = 245;
            char c1 = 'c';
            short s1 = 32767;
            int i1 = 2147483647;
            long l1 = -9223372036854775808;
            float f1 = 34886;
            double d1 = 65546133;
            bool b2 = false;
            string s2 = "This is only  a test. Had this been an actual program it would have been cooler.";
            Console.WriteLine("byte value = {0}\nchar value = {1}\nshort value = {2}\nint value = {3}\nlong value = {4}\nfloat value = {5}\ndouble value = {6}\nbool value = {7}\nstring value = {8}", b1, c1, s1, i1, l1, f1, d1, b2, s2);
            Console.ReadLine();
        }
    }
}
