using System;
using System.Collections.Generic;
using System.Text;

namespace TestMathLib {
    // when using extenions the class needs to be set to public and static in order to work.
    public static class MathLibExtensions {
        public static void print(this String s) {
            Console.WriteLine($"{s}");
        }
        public static int Power(this int a, int b) {
            var answer = 1;
            for(var idx = 0; idx < b; idx++) {
                answer *= a;
            }
            return answer;
        }


        // when making a property static everyting else attached to it must be static as well.// we are using this to show how extension methods work
        public static int Squared(this int a) {
            return a * a;
        }
    }
}
