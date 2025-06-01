using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CounterTask
{
    public class Counter
    {
        // enables Counter object to know its count and name values
        private int _count;
        private string _name;

        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public void Increment()
        {
            _count++; 
            // adds value of count by one

        }

        public void Reset()
        {
            _count = 0;
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

        public int Ticks
        {
            get { return _count; }
        }
        public ResetByDefault{

        }

    }
}