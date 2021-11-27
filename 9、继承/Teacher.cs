using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_继承 {
    public class Teacher : Person {

        public double Salary { get; set; }

        public void Teach() {
            Console.WriteLine("讲课");
        }
    }
}
