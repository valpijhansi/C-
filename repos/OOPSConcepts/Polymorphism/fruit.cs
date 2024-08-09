using System;

namespace Polymorphism
{
    public abstract class fruit
    {
        public abstract void type();
        public abstract void size();


    }
    public class orange : fruit
    {
        public override void type()
        {
            Console.WriteLine("Orange is a citrus fruit");
        }
        public override void size() 
        {
            Console.WriteLine("It is small & round in shape");
        }

        public  void color()
        {
            Console.WriteLine("orange is in saffron color");
        }

    }

    public class Apple : fruit
    {
        public override void size()
        {
            Console.WriteLine("It is small and round in size");
        }

        public override void type() 
        {
            Console.WriteLine("It is sweet in nature");
        }

    }

}
