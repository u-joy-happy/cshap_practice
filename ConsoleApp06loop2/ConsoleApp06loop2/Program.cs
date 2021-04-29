using System;

namespace ConsoleApp06loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConsoleKeyInfo keyInfo;
            //while (true)
            //{
            //    Console.WriteLine("종료 시 [X/x] 입력");
            //    keyInfo = Console.ReadKey();
            //    Console.WriteLine();
            //    if (keyInfo.Key == ConsoleKey.X)
            //    {
            //        break;
            //    }
            //}

            while (true)
            {
                Console.WriteLine("아이디를 입력하세요 : ");
                string id = Console.ReadLine();
                Console.WriteLine("비밀번호를 입력하세요 : ");
                string pw = Console.ReadLine();
                Console.WriteLine("이름을 입력하세요 : ");
                string name = Console.ReadLine();
                Console.WriteLine("전화번호를 입력하세요 : ");
                string tel = Console.ReadLine();
                Console.WriteLine("---------------------");
                Console.WriteLine("ID : {0}\nPassword : {1}\nName : {2}\nTel : {3}\n", id,pw,name,tel);
                Console.WriteLine();
                Console.WriteLine("종료 시 [X/x] 입력");
                keyInfo = Console.ReadKey();
                Console.WriteLine();
                if (keyInfo.Key == ConsoleKey.X)
                {
                    break;
                }
            }

        } // end main
    }
}
