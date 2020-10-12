using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recall that the area of a circle is A = pi * r * r where pi is 3.14 and r is the radius.
            // Desired Output:

            /* Enter a radius: 2.5
               The area of a circle of radius 2.5 is: 19.625
            */

            //Use the System.Math class in C# to get the value of pi and square the radius. The documentation has guidance on how to use the PI field and the Pow method.

            Console.WriteLine("Enter a radius: ");
            string userInputRadius = Console.ReadLine();
            double radius = double.Parse(userInputRadius);

            string circleAreaMsg = "The area of a circle of radius" + radius + " is : ";
            double circleArea = Math.Round(Math.PI * Math.Pow(radius, 2), 3);
            circleAreaMsg += circleArea;

            Console.WriteLine(circleAreaMsg);

            /* Using the same radius, calculate the circumference (2*pi*r) and diameter of the circle (2*r).
               Output the result.
            */

            double circumference = (2 * Math.PI * radius);
            double diameter = (2 * radius);
            Console.WriteLine("Circle Circumference: " + circumference);
            Console.WriteLine(" Circle diameter: " + diameter);

            Console.WriteLine("What's the mpg for your car? ");
            double mpg = double.Parse(Console.ReadLine());

            double gallonsGasUsed = radius / mpg;

            Console.WriteLine("Your car would use" + gallonsGasUsed + "gallons of gas driving around this amazing, bucolic circle.");


        } //Completed minus the bonus missions
    }
}
