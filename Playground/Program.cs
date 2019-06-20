using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            MyObject myObject1 = new MyObject();
            MyObject myObject2 = new MyObject(10, 10);
            Console.WriteLine(myObject1.calculate(10, 10)); // operator overloading
            /*myObject.number1 = 10;
            myObject.number2 = 5;

            Console.WriteLine("Number 1 is " + myObject.number1);
            Console.WriteLine("Number 2 is " + myObject.number2);*/
            Console.WriteLine("object 1 proprety is " + myObject1.number3);
            Console.WriteLine("object 2 proprety is " + myObject2.number3);
            Console.ReadLine();
        }
    }
    
}
