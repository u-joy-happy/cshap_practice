using System;

namespace ConsoleApp04operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("8+3=" + (8 + 3));
            Console.WriteLine("8-3=" + (8 - 3));
            Console.WriteLine("8*3=" + (8 * 3));
            Console.WriteLine("8/3=" + (8 / 3));
            Console.WriteLine("8/3.0=" + (8 / 3.0));
            Console.WriteLine("8%3=" + (8 % 3));

            Console.WriteLine("----------------------");

            Console.WriteLine("8>>1=" + (8 >> 1));
            Console.WriteLine("8<<1=" + (8 << 1));

            Console.WriteLine("----------------------");

            Console.WriteLine("8 & 8=" + (8 & 8));
            Console.WriteLine("8 | 7=" + (8 | 7));
            Console.WriteLine("8 ^ 7=" + (8 ^ 7));

            Console.WriteLine("----------------------");

            int x = 100;
            Console.WriteLine("x += 10 : " + (x += 10));
            Console.WriteLine("x += 10 : " + (x += 10));
            Console.WriteLine("x -= 10 : " + (x -= 10));

            Console.WriteLine("----------------------");
            x = 15;
            Console.WriteLine(x + " &= 10 : " + (x &= 10));
            x = 15;
            Console.WriteLine(x + " |= 10 : " + (x |= 10));
            x = 15;
            Console.WriteLine(x + " <<= 1 : " + (x <<= 1));
            x = 15;
            Console.WriteLine(x + " >>= 1 : " + (x >>= 1));

            Console.WriteLine("----------------------");

            Console.WriteLine("true & true : " + (true & true));
            Console.WriteLine("true && true : " + (true && true));
            Console.WriteLine("false | false : " + (false | false));
            Console.WriteLine("false || false : " + (false || false));

            Console.WriteLine("----------------------");
            Console.WriteLine("5 == 5: " + (5 == 5));            Console.WriteLine("5 != 5: " + (5 != 5));            Console.WriteLine("5 >= 5: " + (5 >= 5));            Console.WriteLine("5 <= 5: " + (5 <= 5));            Console.WriteLine("5 > 5: " + (5 > 5));            Console.WriteLine("5 < 5: " + (5 < 5));

            Console.WriteLine("----------------------");

            string txt = "Hello C#";
            Console.WriteLine("CompareTo : " + (txt.CompareTo("Hello C#") == 0));
            Console.WriteLine("Equals : " + txt.Equals("Hello C#"));

            Console.WriteLine("----------------------");

            x = 200;
            Console.WriteLine(x >= 5 ? "big": "small");

            x = 88;
            Console.WriteLine(x >= 90 ? "A" : x >= 80 ? "B" : "C");

            Console.WriteLine("----------------------");
            // null 대체연산자

            int? nullSu = null;
            nullSu = nullSu ?? 0;
            Console.WriteLine(nullSu);

            string nullStr = null;
            nullStr = nullStr ?? "yangssem";
            Console.WriteLine(nullStr);

        }
    }
}
