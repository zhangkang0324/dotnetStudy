﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_静态和非静态的区别 {
    class Person {

        public static string Name { get; set; }
        public char _gender;

        public void M1() {
            Console.WriteLine("我是非静态方法");
        }

        public static void M2() {
            
            Console.WriteLine("我是静态方法");
        }
    }
}
