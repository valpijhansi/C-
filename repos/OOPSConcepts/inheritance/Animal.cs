using System;
/* Multilevel inheritance :
 * When one class inherits another class which is further inherited by another class, it is known as multi level inheritance in C#. 
 * Inheritance is transitive so the last derived class acquires all the members of all its base classes.
 */
namespace inheritance
{
    public class Animal
    {
        public void eating()
        {
            Console.WriteLine("Animals eat gross");
        }

    }
    public class dog : Animal// It can be extended by Animal Class
    {
        public void sound()
        {
            Console.WriteLine("dogs make sound like bow bow");
        }
    }
    public class cat : dog// It can be derived from both Animal class & dog
    {
        public void size()
        {
            Console.WriteLine("the cat is in small size");
        }
    }
}

