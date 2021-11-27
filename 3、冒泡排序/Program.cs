using System;

namespace _3_冒泡排序 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            int[] nums = { 10, 55, 2, 98, 235 };
            for (int i = 0; i < nums.Length - 1; i++) {
                for (int j = 0; j < nums.Length - 1 - i; j++) {

                    if (nums[j] > nums[j + 1]) {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }

                }
            }
            for (int i = 0; i < nums.Length; i++) {

                Console.WriteLine(nums[i]);
            }
        }
    }
}
