using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_6___Overriding_and_Inheritance
{
    class Person
    {
        public string Name;
        public int Age;
        public Address a;
        public Person()
        {
            
        }
        public Person(string name , int age , Address address )
        {
            Name = name;
            Age = age;
            a = address;
        }
        public override string ToString() => $"Name : {Name}\tAge = {Age}\tAddress is ({a})";
        
    }
}
