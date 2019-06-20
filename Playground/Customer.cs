using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public abstract class Person { // makes it so you can't instantiate Person only the other two
        public string Name { get; set; }

        public void UpdateName (string newName)
        {
            Name = newName;
        } }

    public class Customer : Person
    {
        //encapsulation

        // inheritace is about base classes that extend for other classes
        public int CustomerId { get; set; }
        
    }

    public class Supplier: Person
    {
        public int SupplierId { get; set; }
    }

}
