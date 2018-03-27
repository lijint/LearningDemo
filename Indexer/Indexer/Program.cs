using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new IndexNames();
            name[0] = "hello0";
            name[1] = "hello1";
            name[2] = "hello2";
            name[3] = "hello3";
            name[4] = "hello4";
            name[5] = "hello5";
            name[6] = "hello6";
            name[7] = "hello7";
            name[8] = "hello8";
            name[9] = "hello9";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine(name["hello4"]);
            //Console.WriteLine(name[i]);
            //Console.WriteLine(name[i]);
            
            Console.ReadLine();
        }
    }

    class IndexNames
    {
        private string[] nameList = new string[10];
        public IndexNames()
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                nameList[i] = "N/A";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= nameList.Length - 1)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp;
            }
            set
            {
                if (index >= 0 && index <= nameList.Length - 1)
                {
                    nameList[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index <= nameList.Length)
                {
                    if (nameList[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }
    }
}
