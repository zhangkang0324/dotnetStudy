using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_静态和非静态的区别 {
    public static class Student {

        private static string _name;

        public static string Name {
            get; set;
        }

        public static void M1() {
            Console.WriteLine("我是静态方法");
        }

    }
}
