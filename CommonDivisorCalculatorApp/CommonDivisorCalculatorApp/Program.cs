using System;

namespace CommonDivisorCalculatorApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Greatest Common Divisor App");
            String choice = "y";

            while (choice.Equals("y")) {
                Console.WriteLine("Enter first number: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int x = Convert.ToInt32(Console.ReadLine());

                while (x != 0) {

                    while (y >= x) {
                        y -= x;
                    }
                    int temp = x;
                    x = y;
                    y = temp;
                }
                Console.WriteLine("Greatest common divisor is " + y);
                Console.WriteLine("Continue?  ");
                choice = Console.ReadLine();

            }
            Console.WriteLine("Bye!!!");
        }
    }
}
