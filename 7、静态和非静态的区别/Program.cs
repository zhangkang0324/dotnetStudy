﻿using System;

namespace _7_静态和非静态的区别 {
    class Program {

        /** 静态和非静态的区别
         *  1、在非静态类中既可以有实例成员，也可以有静态成员；
         *  2、在调用实例成员的时候，需要使用对象名.实例成员；
         *     在调用静态成员的时候，需要使用类名.静态成员名；
         *  
         *  总结：
         *  1、静态成员必须使用类名去调用，而实例成员使用对象名调用,
         *  2、静态函数中，只能访问静态成员，不允许访问实例成员，
         *  3、实例函数中，既可以使用静态成员，也可以使用实例成员。
         *  
         *  使用：
         *  1、如果你想要你的类当作一个工具类去使用，这个时候可以考虑将类写成静态类，
         *  2、静态类在整个项目中资源共享，
         *     堆、栈、静态存储区域
         *     只有在程序结束之后，静态类才会释放空间
         */
        public static void Main(string[] args) {

            // 调用实例成员
            Person p = new Person();
            p.M1();
            Person.M2();

            Console.WriteLine("1");

        }

    }
}
