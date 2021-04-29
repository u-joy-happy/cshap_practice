using System;

namespace ConsoleApp06loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //for(int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("i : {0}", i);
            //}
            //Console.WriteLine("------------------");

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine("i : {0}", i);
            //}
            //Console.WriteLine("------------------");

            //for (char i = 'A'; i <= 'z'; i++)
            //{
            //    Console.WriteLine("{0} : {1}", i, (int)i);
            //}
            //Console.WriteLine("------------------");

            //for (char i = '가'; i <= '나'; i++)
            //{
            //    Console.WriteLine("{0} : {1}", i, (int)i);
            //}
            //Console.WriteLine("------------------");

            //for (double i = 1.0; i <= 2.0; i+=0.1)
            //{
            //    Console.WriteLine("i : {0:0.0}", i);
            //}
            //Console.WriteLine("------------------");

            //콘솔에서 입력 받기: Console.ReadLine()
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("점수를 입력하세요");
            //    string kor = Console.ReadLine();
            //    Console.WriteLine(kor + 100);
            //    Console.WriteLine(int.Parse(kor) + 100);
            //}

            Console.WriteLine("-----------------");

            for(int x = 0; x < 3; x++)
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.Write(i + " ");
                    if (i == 5)
                        break;
                    //if (i == 5)
                    //    continue;
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------");

            for (int x = 0; x < 3; x++)
            {
                for (int i = 0; i < 10; i++)
                {
                    //if (i == 5)
                    //    break;
                    if (i == 5)
                        continue;
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------");

            string[] names = new string[] { "kim", "lee", "park" };
            foreach(string item in names)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in names)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");

            int[] sus = new int[] { 11, 22, 33 };
            foreach (int item in sus)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in sus)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------");

            for(int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j,i, (i*j));
                }
                Console.WriteLine();
            }

            int[] nums = { 11, 22, 33 };
            string[] namess = { "kim", "lee", "park" };
            int[] kor = { 99, 68, 87 };
            int[] eng = { 88, 97, 88 };
            int[] math = { 87, 68, 77 };
            int[] total = new int[3];
            double[] avg = new double[3];
            string[] grade = new string[3];

            for(int i = 0; i < nums.Length; i++)
            {
                total[i] = kor[i] + eng[i] + math[i];
                avg[i] = total[i] / 3.0;
                switch ((int) avg[i] / 10)
                {
                    case 10:
                    case 9:
                        grade[i] = "A";
                        break;
                    case 8:
                        grade[i] = "B";
                        break;
                    case 7:
                        grade[i] = "C";
                        break;
                    case 6:
                        grade[i] = "D";
                        break;
                    default:
                        grade[i] = "F";
                        break;
                }

                Console.WriteLine("--------");
                Console.WriteLine("Num : {0}\nName: {1}", nums[i], namess[i]);
                Console.WriteLine("Kor : {0}\nEng : {1}\nMath : {2}", kor[i], eng[i], math[i]);
                Console.WriteLine();
                Console.WriteLine("Total : {0}\nAvg : {1:0.0}\nGrade : {2}", total[i], avg[i], grade[i]);

            }


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("input num:");
                string num2 = Console.ReadLine();
                Console.WriteLine("input name:");
                string name2 = Console.ReadLine();
                Console.WriteLine("input kor:");
                string kor2 = Console.ReadLine();
                Console.WriteLine("input eng:");
                string eng2 = Console.ReadLine();
                Console.WriteLine("input math:");
                string math2 = Console.ReadLine();

                int total2 = int.Parse(kor2) + int.Parse(eng2) + int.Parse(math2);
                double avg2 = total2 / 3.0;
                string grade2 = "A";
                switch ((int)avg2 / 10)
                {
                    case 10:
                    case 9:
                        grade2 = "A";
                        break;
                    case 8:
                        grade2 = "B";
                        break;
                    case 7:
                        grade2 = "C";
                        break;
                    case 6:
                        grade2 = "D";
                        break;
                    default:
                        grade2 = "F";
                        break;
                }
                Console.WriteLine("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", num2, name2, kor2, eng2, math2, total2, avg2, grade2);

            }


        }
    }
}
