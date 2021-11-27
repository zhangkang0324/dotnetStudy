using System;

namespace _4_Out参数 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            /**
             * Out参数
             * 如果你在一个方法中，返回多个相同类型值的时候，可以考虑返回一个数组；
             * 但是，如果返回多个不同数据类型值的时候，返回数据就不行了，那么这个时候，
             * 我们可以使用Out参数。
             * Out参数侧重点在于一个方法中可以返回多个不同类型的值。
             */
            int[] r = { 1, 2, 3, 4 };
            int max = 0;
            int min = 0;
            int sum = 0;
            int avg = 0;
            string s = "";
            // int[] nums = GetMaxMinSumAvg(r);
            // for (int i = 0; i < nums.Length; i++) {
            //     Console.WriteLine(nums[i]);
            // }
            Test(r, out max, out min, out sum, out avg, out s);
            Console.WriteLine("{0}{1}{2}{3}{4}", max.ToString(), min.ToString(), sum.ToString(), avg.ToString(), s);

        }

        public static int[] GetMaxMinSumAvg(int[] s) {

            return s;
        }

        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg, out string s) {
            // out参数要求在方法内部必须为其赋值
            max = nums[0];
            min = nums[1];
            sum = nums[2];
            avg = nums[3];
            s = "4";
        }
    }
}
