using System;
using System.IO;

namespace _11_Path类 {
    class Program {
        static void Main(string[] args) {

            /**
             * Path
             * 
             */
            string str = @"D:\Coding\代码库\5份软件工程经典教程.zip";
            Path.GetFileName(str);
            Console.WriteLine(Path.GetFileName(str));

        }
    }
}
