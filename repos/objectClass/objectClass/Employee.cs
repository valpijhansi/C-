using System;

namespace objectClass
{
    public class Employee
    {
       public int id;
       public string name;
       public  double salary;
        public Employee()
        {

        }
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name+"  "+salary);
        }
    }
}
