using System;

namespace Aggregation
{
    public class Employee
    {

        public int id;
        public string name;
        public int age;
        public string branch;
        public Address address;

        public Employee() { }
        public Employee(int id, string name, int age, string branch,Address address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.branch = branch;
            this.address = address;
        }
        public void show()
        {
            Console.WriteLine(id+" "+name+" "+age+" "+branch+" "+address.village+" "+address.city+" "+address.state+" "+address.country);
        }
        
    }
}
