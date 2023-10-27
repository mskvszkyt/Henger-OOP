using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Henger_OOP_feladat
{
    public class Henger
    {
        double magassag;
        double sugar;
        static int szuletesSzamlalo = 0;

        public double Magassag => magassag;
        public double Sugar => sugar;
        public static int SzuletesSzamlalo => szuletesSzamlalo; 

        public Henger(double sugar, double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }

        public virtual double Terfogat()
        {
            return Math.Pow(sugar, 2) * Math.PI * magassag;
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Math.Round(Terfogat(),2)}; sugár:{sugar}; magasság:{magassag};";
        }
    }
}