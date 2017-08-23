using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            const double pi = 3.14159;
            counter = 1;

            int[] radii = { 15, 32, 108, 74, 9 };
            foreach(int i in radii)
            {
                //declaration statement with initializer
                double circumference = pi * (2 * i);
                Console.WriteLine("Radius of circel #{0} is {1} Circumference = {2:N2}", counter, i, circumference);
                counter++;
                Console.ReadKey();
            }
        }
    }
}
