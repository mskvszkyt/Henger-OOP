using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Henger_OOP_feladat
{
    public class Cso : Henger
    {
        double falvastagsag;

        public Cso(double sugar, double magassag, double falvastagsag) : base(sugar, magassag)
        {
            this.falvastagsag = falvastagsag;
        }

        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            this.falvastagsag = 1;
        }

        //V=π*R1*R1*L
        public override double Terfogat()
        {
            return base.Terfogat() - (Math.Pow((Sugar - falvastagsag), 2) * Math.PI * Magassag);
        }

        public double Falvastagsag => falvastagsag;

        public override string ToString()
        {
            return base.ToString() + $" falvastagság:{falvastagsag}";
        }
    }
}