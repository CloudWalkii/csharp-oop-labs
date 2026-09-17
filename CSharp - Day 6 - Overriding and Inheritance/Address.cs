using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_6___Overriding_and_Inheritance
{
    class Address
    {
        public string City, Street, Zipcode;
        public Address() : this("" , "" ,"")
        {
        }
        public Address(string city) : this(city , "" ,"")
        {
            City = city;
        }
        public Address(string city , string street) : this(city, street, "")
        {
            City = city;
            Street = street;
        }
        public Address(string city , string street , string zipcode) 
        {
            City = city;
            Street = street;
            Zipcode = zipcode;
        }
        public override string ToString() => $"City : {City}\tStreet : {Street}\tZipcode : {Zipcode}";
    }
}
