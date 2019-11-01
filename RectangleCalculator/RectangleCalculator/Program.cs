using System;

namespace RectangleCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Rectangle Calculator");
                        
            double length;
            double width;
            double area;
            double perimeter;
            String choice = "y";
            Console.ReadLine();

            while (choice.Equals("y")) {

                Console.WriteLine("Enter length: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter width:  ");
                width = Convert.ToDouble(Console.ReadLine());

                area = width * length;
                perimeter = 2 * width + 2 * length;

                Console.WriteLine("Area:           " + area);
                Console.WriteLine("Perimeter:      " + perimeter);
                Console.WriteLine("Continue?  y/n: ");
                choice = Console.ReadLine();
            }

                Console.WriteLine("Bye!!!");
        }
    }
}
