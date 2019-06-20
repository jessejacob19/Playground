using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            MyObject myObject = new MyObject();
            myObject.number1 = 10;
            myObject.number2 = 5;

            Console.WriteLine("Number 1 is " + myObject.number1);
            Console.WriteLine("Number 2 is " + myObject.number2);
            Console.WriteLine("The Calculation is " + myObject.calculate());
            Console.ReadLine();
        }
    }
    class MyObject
    {
        //can only access methods or variables if they are public
        //public string myStringProperty { get; set; }

        public int number1 { get; set; }
        public int number2 { get; set; }

        public int calculate()
        {
            return number1 + number2;
        }
        public string MyMethod()
        {
            return "some value";
        }
    }
}
