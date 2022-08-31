using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson5Сycles {
    class Program {
        static void Main(string[] args) {
            const int EXAMPLE_INT = 6;
            MakeCycleWhile(EXAMPLE_INT);
            Console.ReadKey();
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
