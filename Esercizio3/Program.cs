using System;
using System.Collections.Generic;

namespace Esercizio3 {
    class Program {
        public static void Main(string[] args) {
            List<int> intlist = new List<int> { 10,9,8,7,6,5,4,3};
            List<char> charlist = new List<char> { 'u', 'a', 'e', 'i', 'o', 'd', 'c', 's'};
            Conta(intlist,charlist);
        }
        public static int Ordina<T>(List<T> list) where T : IComparable<T> {
            int cont = 0;
            for (int i = 0; i < list.Count - 1; i++) {
                for (int j = i + 1; j < list.Count; j++) {
                    if (list[i].CompareTo(list[j])>0) {
                        T elem = list[i];
                        list[i] = list[j];
                        list[j] = elem;
                        cont++;
                    }
                }
            }
            return cont;
        }
        public static void Conta<T,G>(List<T> list, List<G> list2) where T : IComparable<T> where G:  IComparable<G> {
            int count = Ordina(list);
            count += Ordina(list2);
            StampaList(list);
            StampaList(list2);
            Console.WriteLine("Totale di elementi ordinati"+ count);
        }
        private static void StampaList<T>(List<T> list){
            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
            }
        }
    }
}
