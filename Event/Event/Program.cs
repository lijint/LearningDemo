using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event
{
    class Program
    {
        public class EventTest
        {
            private int value;
            public delegate void NumManidpulationHandler();
            public event NumManidpulationHandler ChangeNum;

            public static void EventFired()
            {
                Console.WriteLine("Binded Event fired");
            }
            protected virtual void OnNumChanged()
            {
                if (ChangeNum != null)
                {
                    ChangeNum();
                }
                else
                {
                    Console.WriteLine("Event Faired");
                }
            }

            public void Setvalue(int num)
            {
                if (value != num)
                {
                    value = num;
                    OnNumChanged();
                }
            }
        }
        static void Main(string[] args)
        {
            EventTest et = new EventTest();
            et.Setvalue(10);
            et.ChangeNum += new EventTest.NumManidpulationHandler(EventTest.EventFired);
            et.Setvalue(100);
        }
    }
}
