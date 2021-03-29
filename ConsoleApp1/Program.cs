using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicMath
{
    public class Program
    {

        public static void Main(string[] args)
        {
        int a = 10;
        int b = 2;        

        addMe(a,b);
        subtractMe(a, b);
        multiplyMe(a, b);
        divideMe(a, b);
        }

        public static void addMe(int val1, int val2)
        {
            int c;
            c = val1 + val2;
            Console.Write("Addition: " + c.ToString() + "\n");  // \n is a new line
            Console.Write("Hit any key to subtract!\n");
            Console.ReadKey();
        }

        public static void subtractMe(int val1, int val2)
        {
            int c;
            c = val1 - val2;
            Console.Write("Subtraction: " + c.ToString() + "\n"); // \n is a new line
            Console.Write("Hit any key to multiply!\n");
            Console.ReadKey();
        }
        public static void multiplyMe(int val1, int val2)
        {
            int c;
            c = val1 * val2;
            Console.Write("Multiplication: " + c.ToString() + "\n"); // \n is a new line
            Console.Write("Hit any key to divide!\n");
            Console.ReadKey();
        }
        public static void divideMe(int val1, int val2)
        {
            int c;
            c = val1 / val2;
            Console.Write("Multiplication: " + c.ToString() + "\n"); // \n is a new line
            Console.Write("Hit any key to exit!"); 
            Console.ReadKey();
        }

    }
}
