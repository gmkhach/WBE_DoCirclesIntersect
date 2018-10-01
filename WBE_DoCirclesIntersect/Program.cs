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
                    Console.Clear();

                    Console.Write("\nEnter the coordinate of the 1st circle's center\n\n>>> ");
                    string[] input1 = Console.ReadLine().Trim().Split(',');
                    double[] center1 = { Convert.ToDouble(input1[0]), Convert.ToDouble(input1[1]) };
                    Console.Write("\nEnter the radius of the 1st circle\n\n>>> ");
                    double radius1 = Convert.ToDouble(Console.ReadLine().Trim());
                    Circle circle1 = new Circle(center1, radius1);

                    Console.Write("\nEnter the coordinate of the 2st circle's center\n\n>>> ");
                    string[] input2 = Console.ReadLine().Trim().Split(',');
                    double[] center2 = { Convert.ToDouble(input2[0]), Convert.ToDouble(input2[1]) };
                    Console.Write("\nEnter the radius of the 2st circle\n\n>>> ");
                    double radius2 = Convert.ToDouble(Console.ReadLine().Trim());
                    Circle circle2 = new Circle(center2, radius2);

                    DoCirclesIntersect(circle1, circle2);
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }

        private static void DoCirclesIntersect(Circle circle1, Circle circle2)
        {
            double distance = Math.Sqrt(Math.Pow(circle1.GetCenter()[1] - circle2.GetCenter()[1], 2) + Math.Pow(circle1.GetCenter()[0] - circle2.GetCenter()[0], 2));
            if (distance == circle1.GetRadius() + circle2.GetRadius() || distance == Math.Abs(circle1.GetRadius() - circle2.GetRadius()))
            {
                Console.WriteLine("\nThe cicles are tangent to each other");
            }
            else if (distance < circle1.GetRadius() + circle2.GetRadius())
            {
                Console.WriteLine("\nThe circles intersect");
            }
            else
            {
                Console.WriteLine("\nThe circles do not intersect and are not tanget to one another");
            }
        }
    }
}
