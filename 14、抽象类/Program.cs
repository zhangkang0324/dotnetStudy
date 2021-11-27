using System;

namespace _14_抽象类 {
    class Program {
        static void Main(string[] args) {

            /** 抽象类
             * 特点：
             * 1、抽象成员必须标记为abstract，并且不能有实现
             * 2、抽象成员必须在抽象类中
             * 3、抽象类不能被实例化
             * 4、子类继承抽象类后，必须把父类中所有的抽象成员都重写（除非子类也是抽象类，则可以不重写）
             * 5、抽象成员的访问修饰符不能是private
             * 6、在抽象类中可以包含实例成员，并且抽象类的实例成员可以不被子类实现。
             * 7、抽象类是有构造函数的，虽然不能 被实例化
             * 8、如果父类的抽象方法中有参数，那么继承这个抽象父类的子类在重写父类方法的时候必须传入对应的参数； 如果抽象父类的抽象方法中有返回值，那么子类在重写这个抽象方法的时候，也必须要传入返回值。
             * 
             * ======
             * 如果父类中的方法有默认的实现，并且父类需要被实例化，这是可以考虑将父类定义成一个普通类，用虚方法来实现多态；
             * 如果父类的方法中没有默认的实现，父类也不需要被实例化，则可以将该类定义为抽象类；
             */

            // 狗狗会叫 猫咪也会叫
            Animal a = new Dog();
            a.Bark();
            Animal b = new Cat();
            b.Bark();
        }
    }

    public abstract class Animal {

        public abstract void Bark();
        public abstract string Name { get; set; }
        public void Test() {
            // 空实现
        }
    }

    public class Dog : Animal {
        public override string Name { get; set; }

        public override void Bark() {
            Console.WriteLine("汪汪汪");
        }
    }

    public class Cat : Animal {
        public override string Name { get; set; }
        public override void Bark() {
            Console.WriteLine("喵喵喵");
        }
    }

}
