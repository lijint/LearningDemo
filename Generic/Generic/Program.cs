using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    class Program
    {

        delegate T mydelegate<T>(T t);
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            mydelegate<int> m1 = new mydelegate<int>(swap);
            m1(1);

            Console.WriteLine("a : {0}; b : {1}", a, b);
            //Console.WriteLine("c : {0}; d : {1}", c, d);
            swap<int>(ref a, ref b);
            Console.WriteLine("a : {0}; b : {1}", a, b);
            Console.ReadLine();
        }

        private static int swap(int i)
        {


        }


        private static void swap<T>(ref T ldata,ref T rdata)
        {
            T temp;
            temp = ldata;
            ldata = rdata;
            rdata = temp;
        }
    }

    public class MyGenericArray<T> where T:struct
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T GetItem(int index)
        {
            return array[index];
        }
        public void SetItem(T value,int index)
        {
            array[index] = value;
        }

        public void other<X>(X x)
        {
            Console.WriteLine(x);
        }
    }
}
