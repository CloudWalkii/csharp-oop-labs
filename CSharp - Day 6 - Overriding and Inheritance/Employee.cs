using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_6___Overriding_and_Inheritance
{
    class Employee : Person
    {
        public string NID;
        public decimal Salary;
        public Employee() : base()
        {
            
        }
        public Employee(string name, int age, Address address, string nid, decimal salary) : base(name, age, address)
        {
            NID = nid;
            Salary = salary;
        }
        public override string ToString() => $"{base.ToString()}\tNID : {NID}\tSalary = {Salary}";
        

    }
}
