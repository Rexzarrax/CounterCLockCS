using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sleeper = 1000;
            int maxLength = 86410 * 7;

            Clock myClock = new Clock();

            Console.WriteLine(myClock.DrawClock());

            //loop calling ticks and printing to console
            for (int i = 0; i <= maxLength; i++)
            {
                System.Threading.Thread.Sleep(Sleeper);
                Console.Clear();
                myClock.IncrementClockSec();
                Console.WriteLine(myClock.DrawClock());
                    
            }
            Console.ReadLine();
        }
    }
}
