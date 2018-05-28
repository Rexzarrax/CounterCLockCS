using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Counter
    {
        private int _count, _maxnum;
        private string _name;

        public Counter(string name, int maxnum)
        {
            _count = 0;
            _name = name;
            _maxnum = maxnum;
        }
        //increase count by 1
        public void Increment()
        {
            _count++;
        }
        //resets value of counter to 0
        public void Reset()
        {
            _count = 00;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;              
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public int Maxnum
        {
            get
            {
                return _maxnum;
            }
            set
            {
                _maxnum = value;
            }
        }
    }
}
