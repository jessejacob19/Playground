using System;

namespace ClassLibrary1
{
    public class MyObject
    {
        //overloaded constructors
        public MyObject()
        {
            _number1 = 5;
            _number2 = 5;
        }

        public MyObject(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        //can only access methods or variables if they are public
        //public string myStringProperty { get; set; }
        int _number1 = 0;
        int _number2 = 0;
        int _number3 = 0;
        /*
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; } */
        public int number1
        {
            get
            {
                return _number1;
            }
            set
            {
                _number1 = value;
            }
        }

        public int number2
        {
            get
            {
                return _number2;
            }
            set
            {
                _number2 = value;
            }
        }

        public int number3
        {
            get
            {
                return _number1 + _number2;
            }
            set
            {
                _number3 = value;
            }

        }




        public int calculate(int number1, int number2)
        {
            return number1 + number2;
        }

        public int calculate()
        //returns the default values
        {
            return _number1 + _number2;
        }
        public string MyMethod()
        {
            return "some value";
        }
    }
}
