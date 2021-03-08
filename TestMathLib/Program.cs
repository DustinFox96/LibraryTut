using System;
using LibraryTut;

            // how we are suppose to do it
namespace TestMathLib {
    class Program {
        static void Main(string[] args) {

            "this is a test".print();

            Console.WriteLine($"3 squarded is {3.Squared()}");
            Console.WriteLine($"2 ^ 3 is {2.Power(3)}");
            // down below is creating an instance so we can use it in our program.
            var mathLib = new MathLib();
            Console.WriteLine($"12 + 3 = {mathLib.Add(12, 3)}");
            Console.WriteLine($"12 - 3 = {mathLib.Subtract(12, 3)}");
            Console.WriteLine($"12 * 3 = {mathLib.Multiply(12, 3)}");
            Console.WriteLine($"12 / 2 = {mathLib.Divide(12, 2)}");
            Console.WriteLine($"12 % 3 = {mathLib.Modulo(12, 3)}");
            Console.WriteLine($"12 ^ 3 = {mathLib.Power(12, 3)}");
            Console.WriteLine($"add is {mathLib.about}");
        }
    }
}

         








            //my attempt
//namespace TestMathLib {
//    class Program {
//        static void Main(string[] args) {

//            var mathLib = new MathLib();
//            Console.WriteLine($"add is {mathLib.Add}");
//        }
//    }
//}
