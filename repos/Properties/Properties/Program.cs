using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{

    public class Customer
    {
        private string _Name;//
        private int _id;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
         public int id
        {
            get

            {  return _id; }
                //return _id }
            set
            {  _id = value;}
               // _id = value;}
        }
    }
    internal class Program

    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Jhansi";
            customer.id = 1;
            Console.WriteLine(customer.Name);
           Console.WriteLine(customer.id);
        }
    }
}
