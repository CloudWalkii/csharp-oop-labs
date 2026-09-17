using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_6___Overriding_and_Inheritance
{
    class Trainee : Person
    {
        public string NID;
        public int IntakeNumber;
        public Trainee() : base()
        {
            
        }
        public Trainee(string nid , int intake, string name, int age, Address address) : base(name, age, address)
        {
            NID = nid;
            IntakeNumber = intake;
        }
        public override string ToString() => $"{base.ToString()}\tNID : {NID}\tIntakeNumber = {IntakeNumber}";

    }
}
