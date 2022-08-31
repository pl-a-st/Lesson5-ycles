using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
            //MakeForEachBreak();
            //MakeForEachContinue();
            MakeForFor(EXAMPLE_INT);
            Console.ReadKey();
        }

        private static void MakeForFor(int exampleInt) {
            for (int i = 0; i < exampleInt; i++) {
                for (int j = 0; j < exampleInt; j++) {
                    Console.Clear();
                    if (i == 0 && j == 0) {
                        continue;
                    }
                    Console.WriteLine($"{i},{j}");
                    Thread.Sleep(300);
                }
            }
        }

        static double GetRandomDouble(Random rnd, double min, double max) {
            return rnd.NextDouble() * (max - min) + min;
        }
        private static void MakeForEachContinue() {
            foreach (char ch in "пример") {
                char newChar = Char.ToUpper(ch);
                if (ch == 'м') {
                    continue;
                }
                Console.WriteLine(newChar);
            }
        }
        private static void MakeForEachBreak() {
            foreach (char ch in "пример") {
                char newChar = Char.ToUpper(ch);
                Console.WriteLine(newChar);
                if (ch == 'м') {
                    break;
                }
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
