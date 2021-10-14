using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void DidTouch(Point point);
    public struct Point
    {
        public int i;
        public int j;

        public Point(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
    public class Shape
    {
        public Point topLeft;
        public Point bottomRight;
        public string Name { get; set; }
        public Shape(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        public Shape(Point topLeft, Point bottomRight, string name) : this(topLeft, bottomRight)
        {
            Name = name;
        }

        public static event EventHandler Outch;

        public void IsTouch(Point point)
        {
            for (int i = topLeft.i; i <= bottomRight.i; i++)
            {
                for (int j = topLeft.j; j <= bottomRight.j; j++)
                {
                    if (point.i == i && point.j == j)
                    {
                        Outch(this, new EventArgs());
                    }
                }
            }
        }
    }
}
