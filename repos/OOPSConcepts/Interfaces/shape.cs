using System;

namespace Interfaces
{
    public interface shape
    {
        
        void Area();
        void perimeter();
    }
    public class rectangle : shape
    {
        public int x = 10;
        public int y = 20;
        public void Area()
        {
            Console.WriteLine("The area of rectangle is:  "+  x*y);

        }
        public void perimeter()
        {
            Console.WriteLine("The perimeter of a rectangle is: " + 2 * (x + y));
        }

    }
    public class cylinder : shape
    {
        public int radius = 2;
        public int height = 3;   

       /* public int Radius
        {
            get
            {
                return _radius;
            }
            set { 
            _radius = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set { 
            _height = value;}
        }*/
        public void Area()
        {

            double surfaceArea = 2 * Math.PI * radius * (radius + height);
            Console.WriteLine("The surface area of the cylinder is: " + surfaceArea);
        }
            public void perimeter()
        {
            double volume = Math.PI * radius * (radius + height) * height;
            Console.WriteLine("The volume of the cylinder is: " + volume); ;
        }
    }
}
