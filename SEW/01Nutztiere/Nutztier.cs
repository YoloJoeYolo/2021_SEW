using System;
using System.Collections.Generic;
using System.Text;

namespace _01Nutztiere
{
    class Nutztier
    {
        protected string name;
        protected int gewichtInKg;

        public Nutztier(string name, int gewichtInKg)
        {
            this.name = name;
            this.gewichtInKg = gewichtInKg;
        }

        public virtual string Lieblingsfutter()
        {
            return "Hier steht ein Lieblingsfutter";
        }

        public override string ToString()
        {
            return "Ich bin " + this.name + " und wiege: " + this.gewichtInKg.ToString() + "kg.";
        }

    }
}
