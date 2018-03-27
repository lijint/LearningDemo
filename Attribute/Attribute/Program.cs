using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Attribute
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            HelpAttribute helpattribute;
            foreach (var attr in typeof(MyClass).GetCustomAttributes(true))
            {
                helpattribute = attr as HelpAttribute;
                if (null != helpattribute)
                {

                }
            }
            Console.ReadLine();
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class HelpAttribute : Attribute
    {
        private string mymsg;
        public HelpAttribute(string msg)
        {
            mymsg = msg;

        }

    }

    [Help("hello")]
    public class MyClass
    {
        [Help("method")]
        [Conditional("LI")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
