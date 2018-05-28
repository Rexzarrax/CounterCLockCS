using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Clock
    {
        Counter[] myTime = new Counter[4];

        public Clock() 
        {
            myTime[0] = new Counter("Sec", 60);
            myTime[1] = new Counter("Min", 60);
            myTime[2] = new Counter("Hrs", 24);
            myTime[3] = new Counter("Days", 7);
        }
        public void IncrementClockSec()
        {
            
            for (int i = 0; i < myTime.Length; i++)
            {
                if (myTime[i].Name == "Sec")
                {
                    myTime[i].Increment();
                }

                if (myTime[i].Count >= myTime[i].Maxnum)
                {
                    myTime[i].Reset();

                    if (i+1 != myTime.Length)
                    {
                        myTime[i + 1].Increment();
                    }                  
                }
            }
        }
        public string DrawClock()
        {
            //string combined = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D2}",myTime[3].Count, myTime[2].Count, myTime[1].Count, myTime[0].Count);
            string combined = "";

            for (int i = myTime.Length-1; i >= 0 ; i--)
            {
                if (i == myTime.Length-1)
                combined += String.Format("{0:D2}", myTime[i].Count);
                else
                combined += String.Format(":{0:D2}", myTime[i].Count);
            }

            return combined;
        }

    }
}
