using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_demo
{
    //This is Subscriber Class
    class Numbers
    {
        static void Main(string[] args)
        {
            AddTwoNumbers objNum = new AddTwoNumbers();
            //Event gets binded with delegates
            objNum.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
            objNum.Add();
            Console.Read();
        }
        //Delegates calls this method when event raised.  
        static void EventMessage()
        {
            Console.WriteLine("Event Executed : This is Odd Number");
        }
    }
    //This is Publisher Class
    class AddTwoNumbers
    {
        //Declared Delegate
        public delegate void dg_OddNumber();
        //Declared Events
        public event dg_OddNumber ev_OddNumber; 

        public void Add()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result.ToString());
            //Check if result is odd number then raise event
            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber(); //Raised Event
            }
        }
    }
}