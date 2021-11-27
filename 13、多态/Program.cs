using System;

namespace _13_多态 {
    class Program {
        static void Main(string[] args) {

            /**
             * 多态
             * 概念：让一个对象能够表现出多种的状态（类型）
             * 
             * 实现多态的3种手段：
             * 1、虚方法；
             *      将父类方法标记为虚方法，使用关键字 Virtual,这个函数 可以被子类重写
             *      什么时候使用？
             *          在对象需要实例化的时候，要使用多态
             * 2、抽象类；
             *      当父类中的方法不知道如何去实现的话，可以考虑将父类写成抽象类，将方法写成抽象方法；
             *      什么时候使用？
             *          在对象不需要实例化，使用抽象类实现多态。
             * 3、接口；
             *      什么时候使用？
             *          根本找不出来父类，都有一个共同的行为特征，使用接口实现多态。
             */
            Chinese c1 = new Chinese("韩梅梅");
            Chinese c2 = new Chinese("李雷");
            Japanese j1 = new Japanese("树下");
            Japanese j2 = new Japanese("井边");
            Korea k1 = new Korea("金秀贤");
            Korea k2 = new Korea("金线绣");
            American a1 = new American("科比");
            American a2 = new American("詹尼");
            Person[] p = { c1, c2, j1, j2, k1, k2, a1, a2 };

            for (int i = 0; i < p.Length; i++) {
                /*if (p[i] is Chinese) {
                    ((Chinese)p[i]).SayHello();
                } else if (p[i] is Japanese) {
                    ((Japanese)p[i]).SayHello();
                } else if (p[i] is Korea) {
                    ((Korea)p[i]).SayHello();
                } else {
                    ((American)p[i]).SayHello();
                }*/
                p[i].SayHello();
            }

            Person pe = new Person("张三");
            pe.SayHello();
            Chinese c = new Chinese("李四");
            c.SayHello();
        }
    }

    public class Person {
        public Person(string name) {
            this.Name = name;
        }

        public string Name { get; set; }
        // 虚方法
        public virtual void SayHello() {
            Console.WriteLine("Hello 我是人类");
        }

    }

    public class Chinese : Person {

        public Chinese(string name) : base(name) {

        }

        public override void SayHello() {
            Console.WriteLine("我是中国人，我叫{0}", this.Name);
        }
    }

    public class Japanese : Person {

        public Japanese(string name) : base(name) {

        }

        public override void SayHello() {
            Console.WriteLine("我是脚盆国人，我叫{0}", this.Name);
        }
    }

    public class Korea : Person {

        public Korea(string name) : base(name) {

        }

        public override void SayHello() {
            Console.WriteLine("我是棒子人，我叫{0}", this.Name);
        }
    }

    public class American : Person {

        public American(string name) : base(name) {

        }

        public override void SayHello() {
            Console.WriteLine("我是米国人，我叫{0}", this.Name);
        }
    }

}
