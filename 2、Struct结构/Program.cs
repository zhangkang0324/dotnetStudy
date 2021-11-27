using System;

namespace _2_Struct结构 {

    public enum Gender {
        男,
        女
    }
    public struct Person {
        public string _name; // 字段
        public int _age;
        public Gender _gender;
    }

    public class Program {
        static void Main() {
            Console.WriteLine("结构学习--------");

            /**
             * 为什么有结构？
             * 结构的用处：可以帮助我们一次性声明多个不同类型的变量
             * 语法： public struct 结构名{'
             *      成员； // 变量
             * }
             */

            /*string name = "张三";
            int age = 22;
            char gender = '男';
            int grand = 3;
            */

            Person zsPerson = new Person();
            zsPerson._name = "张三";
            zsPerson._age = 21;
            zsPerson._gender = Gender.男;

            Person lsPerson = new Person();
            lsPerson._name = "李四";
            lsPerson._age = 22;
            lsPerson._gender = Gender.女;
        }
    }
}
