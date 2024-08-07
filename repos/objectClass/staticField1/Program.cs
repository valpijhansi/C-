using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace staticField1

{
    public class Student
    {
        int ID;
        string Name;
        int phoneNo;
        int salary;
        public static int count = 0;

        public Student() { }
        public Student(int ID, string Name, int phoneNo)
        {
            this.ID = ID;
            this.Name = Name;
            this.phoneNo = phoneNo;
            count++;
        }
        public void display()
        {
            Console.WriteLine(ID + " " + Name+" "+phoneNo);
        }


    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Student student = new Student(1,"Jhansi",709361931);
            Student student1 = new Student(2, "Lokesh", 938142942);
            Console.WriteLine("No of objects created: "+ Student.count);
            student.display();

        }
    }
}
