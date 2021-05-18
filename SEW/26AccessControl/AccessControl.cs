using System;
using System.Collections.Generic;
using System.Text;

namespace _26AccessControl
{
    class AccesControl
    {
        private int currentCount = 0;
        private int maxCount;

        public AccesControl(int maxCount)
        {
            this.maxCount = maxCount;
        }

        public int CurrentCount
        {
            get
            {
                return this.currentCount;
            }
            set
            {
                this.currentCount++;
            }
        }

        public bool canEnter(int persons = 1)
        {
            return this.currentCount + persons <= this.maxCount && this.currentCount + persons >= 0;
        }

        public void Increment(int count = 1)
        {
            this.currentCount += count;
        }

        public void Decrement(int count = 1)
        {
            this.currentCount -= count;
        }
    }
}
