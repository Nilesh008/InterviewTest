using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest
{
    public class A
    {
        int defaultNumber;
        public A()
        {            
            Console.WriteLine("Default Constructor is called");
        }
        public A(int _p)
        {
            defaultNumber = _p;
            //Console.WriteLine($"Parameterized Constructor is called : {defaultNumber}");
        }
        public A(A objA)
        {
            defaultNumber = objA.defaultNumber;
            Console.WriteLine();
        }
        public void Area()
        {
            Console.WriteLine("Class A Method is called");
        }

        public void Display()
        {
            Console.WriteLine($"Value of Number is : {defaultNumber}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int ab = new int();
            ab = 20;

            Console.WriteLine(ab);
            A aObj = new A(10);
            A a2Obj = new A(aObj);
            a2Obj.Display();
            Console.ReadKey();
        }
    }
}
