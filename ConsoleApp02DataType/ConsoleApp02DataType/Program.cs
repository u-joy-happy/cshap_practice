using System;

namespace ConsoleApp02DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Boolean
            bool b = true;
            Console.WriteLine(b);

            //Numeric
            byte byt = 10;  //unsigned byte
            Console.WriteLine(byt);
            Console.WriteLine(byte.MinValue + " ~ " + byte.MaxValue);

            sbyte byt2 = -10; //signed byte
            Console.WriteLine(byt2);
            Console.WriteLine(sbyte.MinValue + " ~ " + sbyte.MaxValue);

            short sh = -32768;
            Console.WriteLine(sh);
            Console.WriteLine(short.MinValue + " ~ " + short.MaxValue);

            int su = 2147483647;
            Console.WriteLine(su);
            Console.WriteLine(int.MinValue + " ~ " + int.MaxValue);

            long lng = 4292147483647L;
            Console.WriteLine(lng);
            Console.WriteLine(long.MinValue + " ~ " + long.MaxValue);

            float f = 123.45f;
            Console.WriteLine(f);
            Console.WriteLine(float.MinValue + " ~ "+ float.MaxValue);

            double d1 = 123.45;
            Console.WriteLine(d1);
            Console.WriteLine(double.MinValue + " ~ " + double.MaxValue);

            double d2 = 123.45D; //D suffix
            Console.WriteLine(d2);
            Console.WriteLine(double.MinValue + " ~ " + double.MaxValue);

            decimal dcm = 9769983423.45M; //M suffix
            Console.WriteLine(dcm);
            Console.WriteLine(decimal.MinValue + " ~ " + decimal.MaxValue);


            //char/String
            char c = 'A';
            Console.WriteLine(c);
            Console.WriteLine(char.MinValue + " ~ " + char.MaxValue);
            Console.WriteLine("{0} ~ {1}", char.MinValue, char.MaxValue);

            string s;
            s = null;
            Console.WriteLine(s);
            s = "yangssem";
            Console.WriteLine(s);

            DateTime date = new DateTime(2022, 12, 25, 12, 35, 00);
            Console.WriteLine(date);
            //date = new DateTime(); //1/1/0001 12:00:00 AM

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));

            Console.WriteLine(date.ToString("yyyy MM dd HH:mm:ss"));


            //Nullable
            //int nable = null;
            int? nable = null;
            Console.WriteLine(nable);
            bool? nablebool = null;
            Console.WriteLine(nablebool);

            Nullable<int> nullablesu = null;
            Console.WriteLine(nullablesu);
            nullablesu = 100;
            //int i = nullablesu;
            int i = nullablesu.Value;
            Console.WriteLine(i);
        }
    }
}
