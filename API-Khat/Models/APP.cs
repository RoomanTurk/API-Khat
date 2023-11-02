using System.Drawing;

namespace API_Khat.Models
{
    public class APP
    {
        public bool isOnLineA;
        public bool isOnLineB;
        static bool IsPointOnLine(Point A, Point B, Point C)
        {
            int ABx = B.X - A.X;
            int ABy = B.Y - A.Y;
            int ACx = C.X - A.X;
            int ACy = C.Y - A.Y;
            int crossProduct = ABx * ACy - ABy * ACx;
            if (crossProduct != 0)
            { return false; }
            int dotProduct = ABx * ACx + ABy * ACy;
            if (dotProduct < 0)
            { return false; }
            int squareLengthAB = ABx * ABx + ABy * ABy;
            if (dotProduct > squareLengthAB)
            { return false; }
            return true;
        }
        public void A()
        {
            Point A = new Point { X = 1, Y = 1 };
            Point B = new Point { X = 20, Y = 20 };
            Point C = new Point { X = 9, Y = 9 };
            isOnLineA = IsPointOnLine(A, B, C);
        }
        public void B()
        {
            Point A = new Point { X = 1, Y = 1 };
            Point B = new Point { X = 20, Y = 20 };
            Point C = new Point { X = 23, Y = 23 };
            isOnLineB = IsPointOnLine(A, B, C);
        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
