using System;

namespace ConsoleApp15optional_params
{
    class Calculate
    {
        public void Call(int su1, int su2, string key = "+")
        {
            Console.WriteLine("key : {0}", key);
            switch (key)
            {
                case "+":
                    Console.WriteLine("{0}+{1}={2}", su1, su2, su1 + su2);
                    break;
                case "-":
                    Console.WriteLine("{0}-{1}={2}", su1, su2, su1 - su2);
                    break;
                case "*":
                    Console.WriteLine("{0}*{1}={2}", su1, su2, su1 * su2);
                    break;
                case "/":
                    Console.WriteLine("{0}/{1}={2}", su1, su2, su1 / su2);
                    break;
                default:
                    break;
            }
            Console.WriteLine("======================");
        }

        public void Sum(params int[] sus)
        {
            int sum = 0;
            foreach (var su in sus)
            {
                sum += su;
            }
            Console.WriteLine("sum : {0}", sum);
        }

        public void Info(params string[] names)
        {
            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculate cal = new Calculate();
            int su1 = 100;
            int su2 = 200;
            cal.Call(su1, su2, "*");
            cal.Call(su1, su2, "/");
            cal.Call(su1, su2);
            cal.Call(su1, su2, "-");
            cal.Sum(22, 44, 55, 66, 77);
            cal.Sum(new int[] { 1, 2, 3, 4 });
            cal.Info("aa","bb","cc","dd");
            cal.Info(new string[] { "kim","lee","park" });
        }
    }
}
