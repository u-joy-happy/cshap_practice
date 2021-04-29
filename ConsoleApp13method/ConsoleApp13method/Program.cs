using System;

namespace ConsoleApp13method
{
    class Calculate
    {
        public void Sum(int su1, int su2)
        {
            su1++;
            su2++;
            Console.WriteLine("{0}+{1}={2}", su1, su2, su1 + su2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            static void method1()
            {
                Console.WriteLine("method1()");
            }

            static int method2()
            {
                Console.WriteLine("method2()");
                return 100;
            }

            static void method3(int x, int y)
            {
                Console.WriteLine("method3(int {0}, int {1})", x, y);
            }

            static string method4(string x, string y)
            {
                Console.WriteLine("method4(string {0}, string {1})", x, y);
                return "Hello C#";
            }


            Console.WriteLine("Method ----------");

            Console.WriteLine("return X args X --------");
            method1();

            Console.WriteLine("return O args X --------");
            int res = method2();
            Console.WriteLine(res);

            Console.WriteLine("return X args O --------");
            method3(10, 20);

            Console.WriteLine("return O args O --------");
            string msg = method4("aaa", "bbb");
            Console.WriteLine(msg);

            Console.WriteLine();

            Console.WriteLine("Pass by Value -------");

            Calculate cal = new Calculate();

            int su1 = 5;
            int su2 = 3;

            cal.Sum(su1, su2);
            Console.WriteLine("su1:{0}, su2:{1}", su1, su2);

        }
    }

}
