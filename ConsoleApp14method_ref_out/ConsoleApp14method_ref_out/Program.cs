using System;

namespace ConsoleApp14method_ref_out
{
    class Calculate
    {
        public void Sum(ref int su1, ref int su2)
        {
            su1++;
            su2++;
            Console.WriteLine("{0}+{1}={2}", su1, su2, su1 + su2);
        }

        public void Minus(int x, int y, out int su3, out int su4)
        {
            su3 = x - 10;
            su4 = y - 10;
            Console.WriteLine("{0}-{1}={2}", su3, su4, su3-su4);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculate cal = new Calculate();

            //메서드를 호출할 때 ref키워드 명시와 인자 초기화 필요
            int su1 = 100;
            int su2 = 200;
            cal.Sum(ref su1, ref su2);
            Console.WriteLine("su1={0},su2={1}", su1, su2);

            //ref를 사용하여 호출한 메서드 내부에서 값을 변경하면
            //호출자의 실제 값도 변경된다.

            Console.WriteLine();


            //메서드를 호출할 때 out키워드 명시 필요 (초기화 불필요)
            int su3, su4;
            cal.Minus(100, 200, out su3, out su4);
            Console.WriteLine("su3={0},su4={1}", su3, su4);

            //out을 사용하여 호출한 메서드 내부에서 값을 할당해주면
            //호출자의 실제 필드에도 할당된다.


        }
    }
}
