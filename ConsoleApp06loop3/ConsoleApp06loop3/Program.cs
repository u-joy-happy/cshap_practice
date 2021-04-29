using System;

namespace ConsoleApp06loop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConsoleKeyInfo keyInfo;
            //do
            //{
            //    Console.WriteLine("종료시 [X/x] 입력");
            //    keyInfo = Console.ReadKey();
            //    Console.WriteLine("KeyInfo.key : {0}", keyInfo.Key);
            //    Console.WriteLine();

            //} while (keyInfo.Key != ConsoleKey.X);

            // ##### 자판기 프로그램 #####
            int money = 0;

            do
            {
                Console.WriteLine("충전 금액을 입력하세요");
                money += int.Parse(Console.ReadLine());
                Console.WriteLine("현재 잔액 : {0}원", money);
                Console.WriteLine();

                Console.WriteLine("음료를 선택하세요");
                Console.WriteLine("1 : 콜라 500원\n2 : 주스 1000원\n3 : 식혜 1500원\n");
                string drink = Console.ReadLine();
                switch (drink)
                {
                    case "1":
                        Console.WriteLine("콜라를 선택하였습니다.");
                        if ((money - 500) >= 0)
                        {
                            Console.WriteLine("콜라가 나왔습니다.");
                            money -= 500;
                            Console.WriteLine("현재 잔액 : {0}원", money);
                        }
                        else
                        {
                            Console.WriteLine("돈이 {0}원 부족합니다.", 500-money);
                        }
                        break;
                    case "2":
                        Console.WriteLine("주스를 선택하였습니다.");
                        if ((money - 1000) >= 0)
                        {
                            Console.WriteLine("주스가 나왔습니다.");
                            money -= 1000;
                            Console.WriteLine("현재 잔액 : {0}원", money);
                        }
                        else
                        {
                            Console.WriteLine("돈이 {0}원 부족합니다.", 1000 - money);
                        }
                        break;
                    case "3":
                        Console.WriteLine("식혜를 선택하였습니다.");
                        if ((money - 1500) >= 0)
                        {
                            Console.WriteLine("식혜가 나왔습니다.");
                            money -= 1500;
                            Console.WriteLine("현재 잔액 : {0}원", money);
                        }
                        else
                        {
                            Console.WriteLine("돈이 {0}원 부족합니다.", 1500 - money);
                        }
                        break;
                    default:
                        Console.WriteLine("잘못 선택하였습니다.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("종료시 [X]\n계속 하려면 아무키 입력");
                keyInfo = Console.ReadKey();
                //Console.WriteLine("KeyInfo.key : {0}", keyInfo.Key);
                Console.WriteLine();
            } while (keyInfo.Key != ConsoleKey.X);

            Console.WriteLine("end main");
        } // end main
    }
}
