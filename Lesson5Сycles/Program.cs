using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson5Сycles {
    class Program {
        static void Main(string[] args) {
            const int EXAMPLE_INT = 6;
            double min = 2;
            double max = 8;
            Random rnd = new Random();
            //MakeCycleWhile(EXAMPLE_INT);
            //MakeCycleDoWhile(rnd, min, max, EXAMPLE_INT);
            //MakeCucleFor(EXAMPLE_INT);
            MakeForEach();
            Console.ReadKey();
        }
        static double GetRandomDouble(Random rnd, double min, double max) {
            return rnd.NextDouble() * (max - min) + min;
        }
        private static void MakeForEach() {
            foreach (char ch in "пример") {
                char newChar = Char.ToUpper(ch);
                Console.WriteLine(newChar);
            }
        }
        static void MakeCucleFor(int example) {
            for (int i = 200; i >= example; i /= 2) {
                Console.WriteLine(i);
            }
        }
        static void MakeCycleDoWhile(Random rnd, double min, double max, int example) {
            double myDouble;
            do {
                myDouble = GetRandomDouble(rnd, 2, 8);
                Console.WriteLine(myDouble);
            }
            while (myDouble < example);
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
