using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppNetFamework.ENTITIES;

namespace WebAppNetFamework.BUSINESS_SERVICES
{
    public class SOLVE_TRIANGLE
    {
        public static double TrianglePerimeter(TRIANGLE tria)
        {
            double edge1 = LengthTwoPoints(tria.diemA, tria.diemB);
            double edge2 = LengthTwoPoints(tria.diemB, tria.diemC);
            double edge3 = LengthTwoPoints(tria.diemC, tria.diemA);
            return edge1 + edge2 + edge3;
        }
        //length of two points
        static double LengthTwoPoints(POINT A, POINT B)
        {
            //squared angle
            int sa1 = Math.Abs(A.x - B.x);
            int sa2 = Math.Abs(A.y - B.y);
            double length = Math.Sqrt(sa1 * sa1 + sa2 * sa2);
            return length;

        }
    }
}