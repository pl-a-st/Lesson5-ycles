using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson5Сycles {
    class Program {
        static void Main(string[] args) {
            const int EXAMPLE_INT = 6;
            Random rnd = new Random();
            //MakeCycleWhile(EXAMPLE_INT);
            double myDouble = GetRandomDouble(rnd, 2, 8);
            Console.WriteLine(myDouble);
            Console.ReadKey();
        }
        static double GetRandomDouble(Random rnd, double min, double max) {
            return rnd.NextDouble() * (max - min) + min;
        }
        static void MakeCycleWhile(int exampleInt) {
            int startInt = 0;
            while (startInt < exampleInt) {
                Console.WriteLine(startInt);
                startInt++;
            }
        }
    }
}
