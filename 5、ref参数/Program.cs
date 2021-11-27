using System;

namespace _5_ref参数 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("ref参数学习");
            /**
             * ref参数
             * 能够将一个变量带入一个方法中进行改变，改变完成后的值带出方法；
             */

            // 使用方法来交换两个int类型的值
            int n1 = 10;
            int n2 = 20;

            swap(ref n1, ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }

        public static void swap(ref int n1, ref int n2) {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
