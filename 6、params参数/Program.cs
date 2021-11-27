using System;

namespace _6_params参数 {
    class Program {
        static void Main(string[] args) {

            /**
             * params可变参数
             * 将实参列表中跟可变参数数组类型一致的元素都当作数组的元素去处理；
             * params可变参数必须是形参列表中最后一个元素；
             */
            // int[] s = { 54, 61, 85 };
            Test("张三", 54, 61, 85);

        }

        // params使用中必须放在最后一个参数
        public static void Test(string name, params int[] score) {
            int sum = 0;
            for (int i = 0; i < score.Length; i++) {
                sum += score[i];
            }
            Console.WriteLine("{0}本次考试成绩是：{1}", name, sum);
        }
    }
}
