using System;
using System.Collections.Generic;

namespace _12_泛型 {
    class Program {
        static void Main(string[] args) {

            // 创建泛型集合对象
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(22);
            list.Add(333);

            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
            }
        }
    }
}
