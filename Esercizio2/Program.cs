using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2 {
    class Program {
        public static void Main(string[] args) {
            string str = "io po della po della io";
            Console.WriteLine(Conta(str));
        }
        public static int Conta(string str) {
            string[] liststr= str.Split(' ');
            int cont = 0;
            for (int i=0; i< liststr.Length-1;  i++) {
                for(int j=i+1; j< liststr.Length; j++) {
                    if(liststr[i] == liststr[j]) {
                        cont++;
                    }
                }
            }
            return cont;
        }
    }
}
