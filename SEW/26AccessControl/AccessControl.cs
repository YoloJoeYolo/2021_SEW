﻿using System;
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

        public bool canEnter()
        {
            return this.currentCount < this.maxCount;
        }

        public void Increment()
        {
            this.currentCount++;
        }

        public void Increment(int count)
        {
            this.currentCount += count;
        }

        public void Decrement()
        {
            this.currentCount--;
        }

        public void Decrement(int count)
        {
            this.currentCount -= count;
        }
    }
}
