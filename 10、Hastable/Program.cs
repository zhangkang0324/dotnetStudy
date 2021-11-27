using System;
using System.Collections;

namespace _10_Hastable {
    class Program {
        static void Main(string[] args) {

            /** hastable 键值对集合 字典
             * 
             * 
             * 
             */
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, "男");

            

            Console.WriteLine(ht[1]);

            foreach (var item in ht.Values) {
                Console.WriteLine(item);
            }
        }
    }
}
