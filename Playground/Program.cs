using ClassLibrary1;
using System;


namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer();
            //var calc = new ClassLibrary1.Calculate();
            //var result = calc.PerformCal(10, 10);

            ClassLibrary1.ICalculate addfunction = new ClassLibrary1.AddCalculate();
            ClassLibrary1.ICalculate subtractfunction = new ClassLibrary1.SubtractCalculate();
            ClassLibrary1.ICalculate multiplyfunction = new ClassLibrary1.MultiplyCalculate();

            var result = multiplyfunction.PerformCal(10, 10);

            ClassLibrary1.MyObject myObject1 = new ClassLibrary1.MyObject();// references to another namespace
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
