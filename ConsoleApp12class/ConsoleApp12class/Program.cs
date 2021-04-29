using System;
using Test;

namespace Test
{
    class Car
    {
        public string model = "0000";
        public int price = 500;

        //propfull + \t\t
        private string pnumber = "kosta1004";

        public string Pnumber
        {
            get { return pnumber; }
            set { pnumber = value; }
        }

        public override string ToString()
        {
            return string.Format("Car[ model={0}, price={1}, number={2} ]", model, price, Pnumber);
        }


    }

    class Student
    {
        //prop + \t\t
        public string Name { get; set; }
        public object Age { get; set; }
        public int Kor { get; set; }

        //override + \t, to + \t
        public override string ToString()
        {
            return "Student[ name=" + Name + ", age=" + Age + ", kor=" + Kor + " ]";
        }


    }
}

namespace ConsoleApp12class
{
    /* internal */class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}
