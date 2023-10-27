using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Henger_OOP_feladat
{
    public class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }
        //7.87
        public TomorHenger(double sugar, double magassag) : base(sugar, magassag)
        {
            this.fajsuly = 7.87;
        }

        public double Fajsuly => fajsuly;
        public double Suly => fajsuly * Terfogat();


        public override string ToString()
        {
            return base.ToString() + $" fajsúly:{fajsuly}";
        }
    }
}