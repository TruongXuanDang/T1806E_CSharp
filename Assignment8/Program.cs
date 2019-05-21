using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArrayList<string, int> myGenericArrayList = new MyGenericArrayList<string, int>();
            myGenericArrayList.key = "abc";
            myGenericArrayList.value = 10;
            Console.WriteLine(myGenericArrayList.key);
            Console.WriteLine(myGenericArrayList.value);
            Console.ReadKey();
        }
    }

    public class MyGenericArrayList<K,V>
    {
        public K key;
        public V value;
    }
}
