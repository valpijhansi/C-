using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("KKM","ODC","AP","India");
            Employee emp = new Employee(12,"Jhansi",23,"IT",address);
            emp.show();
        }
    }
}
