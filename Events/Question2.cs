using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class EnterNumbers
    {
        public static void SetNum()
        {
            int num = 0, count = 0;
            Console.WriteLine("Enter numbers and find the lucky number");
            while (num != 999)
            {
                int.TryParse(Console.ReadLine(), out num);
                count++;
            }
            if (LuckyNumber != null)
            {
                LuckyNumber(count, new MyEventArgs(count));
                //LuckyNumber(count, count);
            }
        }

        public static event EventHandler<MyEventArgs> LuckyNumber;
        //public static event EventHandler<int> LuckyNumber;

        public static void LuckyNumberMessage(object sender, MyEventArgs e)
        {
            Console.WriteLine("Lucky number was entered after {0} tries", e.count);
        }
        public static void LuckyNumberMessage(object sender, int e)
        {
            Console.WriteLine("Lucky number was entered after {0} tries", e);
        }
    }
    public class MyEventArgs: EventArgs
    {
        public int count;

        public MyEventArgs(int count)
        {
            this.count = count;
        }
    }
}
