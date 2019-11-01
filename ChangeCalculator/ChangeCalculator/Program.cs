using System;

namespace ChangeCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Change Calculator");

            String choice = "y";


            while (choice.Equals("y")) {
                int qCounter = 0;
                int dCounter = 0;
                int nCounter = 0;
                int pCounter = 0;
                Console.WriteLine("Enter number of cents (0-99):  ");
                int cents = Convert.ToInt32(Console.ReadLine());
                while (cents >= 25) {
                    int total = (cents - 25);
                    cents = total;
                    qCounter++;
                }

                while (cents >= 10) {
                    int total = (cents - 10);
                    cents = total;
                    dCounter++;
                }

                while (cents >= 5) {
                    int total = (cents - 5);
                    cents = total;
                    nCounter++;
                }

                while (cents >= 1) {
                    int total = (cents - 1);
                    cents = total;
                    pCounter++;
                }

                Console.WriteLine("Quarters:     " + qCounter);
                Console.WriteLine("Dime:         " + dCounter);
                Console.WriteLine("Nickel:       " + nCounter);
                Console.WriteLine("Penny:        " + pCounter);
                Console.WriteLine("Continue:  y/n");
                choice = Console.ReadLine();


            }
            Console.WriteLine("Goodbye");
        }
    }
}
