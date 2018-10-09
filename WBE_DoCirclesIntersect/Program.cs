/*
 * Design a circle class.
 * Given two circles write a method to determine if the they intersect. 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_DoCirclesIntersect
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    // collecting information for the 1st circle
                    Console.Write("\nEnter the coordinate of the 1st circle's center\n\n>>> ");
                    string[] input1 = Console.ReadLine().Trim().Split(',');
                    double[] center1 = { Convert.ToDouble(input1[0]), Convert.ToDouble(input1[1]) };
                    Console.Write("\nEnter the radius of the 1st circle\n\n>>> ");
                    double radius1 = Convert.ToDouble(Console.ReadLine().Trim());
                    Circle circle1 = new Circle(center1, radius1);
                    // collecting information for the 2nd circle
                    Console.Write("\nEnter the coordinate of the 2st circle's center\n\n>>> ");
                    string[] input2 = Console.ReadLine().Trim().Split(',');
                    double[] center2 = { Convert.ToDouble(input2[0]), Convert.ToDouble(input2[1]) };
                    Console.Write("\nEnter the radius of the 2st circle\n\n>>> ");
                    double radius2 = Convert.ToDouble(Console.ReadLine().Trim());
                    Circle circle2 = new Circle(center2, radius2);
                    // call the DoCirclesIntersect method to help building the output string
                    Console.WriteLine("\nThe cicles " + DoCirclesIntersect(circle1, circle2));
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try again...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        private static string DoCirclesIntersect(Circle c1, Circle c2)
        {
            // Nested Ternary operator expression
            double dist = Math.Sqrt(Math.Pow(c1.GetCenter()[1] - c2.GetCenter()[1], 2) + Math.Pow(c1.GetCenter()[0] - c2.GetCenter()[0], 2));
            return (dist == c1.GetRadius() + c2.GetRadius() || dist == Math.Abs(c1.GetRadius() - c2.GetRadius()) ? "are tangent to each other" : 
                   (dist < c1.GetRadius() + c2.GetRadius() && dist > Math.Abs(c1.GetRadius() - c2.GetRadius())? "intersect" : "do not intersect and are not tangent to one another"));
        }
    }
}
