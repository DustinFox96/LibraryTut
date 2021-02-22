using System;

// how this is suppose to be done 
namespace LibraryTut {
    public class MathLib {

        public string about { get; set; } = "About MathLib";

        public int Add(int a, int b) {
            return a + b;
        }
        public int Subtract(int a, int b) {
            return a - b;
        }
        public int Multiply(int a, int b) {
            return a * b;
        }
        public int Divide(int a, int b) {
            return a / b;
        }
        // you could also just do it the short hand sign with % looking like this a % b;
        public int Modulo(int a, int b) {
            return a - (a / b * b); 

        }
        public int Power(int a, int b) {
            var answer = 1;
            for (var idx = 0; idx < b; idx++) {
                answer *= a;
            }
            return answer;
        }
    }
}















            //my attempt
//namespace LibraryTut {
//    public class MathLib {

//        public string about { get; set; } = "About MathLib";

//        public  int Add(int a , int b) {
//            return a + b; 
//        }
//        public int Subtract(int a, int b) {
//            return a - b;
//        }
//        public int Multiply(int a, int b) {
//            return a * b;
//        }
//        public int Divide(int a, int b) {
//            return a / b;
//        }
//        public int Modulo(int a, int b) {
//            return a - (a / b * b);

//        }
//        public int Power(int a, int b) {
//            var answer = 1;
//            for(var idx = 0; idx < b; idx++) {
//                answer *= a;
//            }
//            return answer;
//        }
//    }
//}
