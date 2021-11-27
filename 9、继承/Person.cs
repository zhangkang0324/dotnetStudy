using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_继承 {
    public class Person {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public void CHLSS() {
            Console.WriteLine("吃喝拉撒睡");
        }

    }
}
