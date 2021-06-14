using System;
using System.Collections.Generic;
using System.Text;

namespace _01Nutztiere
{
    class Schaf : Nutztier
    {
        private int milchleistungInKg;

        public Schaf(string name, int gewichtInKg, int milchleistungInKg) : base(name, gewichtInKg)
        {
            this.milchleistungInKg = milchleistungInKg;
        }

        public int MilchleistungInKg
        {
            get
            {
                return this.milchleistungInKg;
            }
            set
            {
                this.milchleistungInKg = value;
            }
        }

        public override string Lieblingsfutter()
        {
            return "Mein Lieblingsfutter ist Heu!";
        }
    }
}
