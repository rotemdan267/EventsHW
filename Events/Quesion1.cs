using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void PrintMessage();

    internal class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 10)
                {
                    if (TooLongNameEvent != null)
                    {
                        TooLongNameEvent();
                    }
                }
                name = value;
            }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public static event PrintMessage TooLongNameEvent = Message;


        public static void Message()
        {
            Console.WriteLine("The name cannot contain over 10 characters");
        }
    }
}
