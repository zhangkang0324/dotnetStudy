using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_继承 {
    public class Dirver : Person {

        public int DirveTime { get; set; }
        public void Drive() {
            Console.WriteLine("开车");
        }
    }
}
