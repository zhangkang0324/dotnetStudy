using System;

namespace _1_Enum枚举 {

    class Program {
        static void Main(string[] args) {

            Console.WriteLine("枚举学习--------");

            /**
             * 枚举的定义
             * 
             * 为什么会有枚举这个东西？
             * 性别、月份等固定的值，其他地方可以随时获取
             * 
             * 语法： public enum 枚举名
             * { 值1，
             *   值2，
             *   值3
             *   ... 
             * }
             */

            // 枚举的使用
            // 枚举类型跟int类型可以互相转换
            #region 枚举类型转换int类型

            Gender gender = Gender.男;
            Console.WriteLine((int)gender);

            #endregion
            Console.WriteLine("--------");
            #region int类型转枚举类型

            int s1 = 2;
            Season season = (Season)s1;
            Console.WriteLine(season);

            #endregion
            Console.WriteLine("--------");
            #region 枚举类型转string类型
            Season season2 = Season.春;
            string s = season2.ToString();
            Console.WriteLine(s);
            #endregion
            Console.WriteLine("--------");
            #region 将string类型转枚举类型
            string ss = "0";
            Season sseason = (Season)Enum.Parse(typeof(Season), ss);
            Console.WriteLine(sseason);
            #endregion
        }
    }

    // 枚举是一个变量类型
    // 只是枚举声明、赋值、使用的方式跟那些普通的变量类型不一样
    public enum Gender {
        男 = 3,
        女
    }

    public enum Season {
        春,
        夏,
        秋,
        冬
    }
}
