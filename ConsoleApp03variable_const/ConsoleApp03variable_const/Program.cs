using System;

namespace ConsoleApp03variable_const
{
    class Program
    {
        string model = "BMW";
        const string model2 = "BMW2";

        readonly string name = "yangssem";

        Program()
        {
            name = "lee"; //생성자에서는 변경 가능
            //model2 = "Audi"; //생성자에서도 변경 불가
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 줄 복사 command D
            // 줄 삭제 command L

            // readonly
            // 전역변수에서만 선언 가능
            // 객체 생성 후 접근 가능 (객체 이름으로 접근 불가)

            // const
            // 전역, 지역변수에서 선언 가능
            // 객체(클래스) 이름으로 접근 가능 (객체 생성한 변수로 접근 불가)
            Program p = new Program();
            Console.WriteLine(p.model);
            Console.WriteLine(Program.model2);
        }
    }
}
