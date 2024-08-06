namespace functions
{
    namespace functions
    {
        internal partial class Program
        {
            public class Point
            {
                public int X;
                public int Y;

                public Point()
                {
                }

                public Point(int x, int y)
                {
                    this.X = x;
                    this.Y = y;
                }

                public void move(int x, int y)
                {
                    this.X = x;
                    this.Y = y;
                }

                public void move(Point p)
                {
                    move(p.X, p.Y);
                }
            }
        }
    }





}
