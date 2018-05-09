using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1 {
    class Program {
        static void Main() {
            int i = 0;
            for (; i<=15; i++) {
                if(i%2 == 0) {
                    Console.WriteLine(i);    
                }
            }
            Console.WriteLine("-----");
            for (; 1 <= i; i--) {
                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
