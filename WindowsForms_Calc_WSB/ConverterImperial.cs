using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Calc_WSB
{
    
    internal class ConverterImperial 
    {
        /*
        Object contining methods returning values in imperial units
        */

        private double foot = 30.48;
        private double pound = 0.45359237;
        private double grain = 0.06479891;
        private double spine = 1; //find correct ratio

        public ConverterImperial() { }

        double poundage(double kilos, int round)
        {
            return Math.Round(kilos / pound, round);
        }

        double weight(double grams, int round)
        {
            return Math.Round(grams / grain, round);
        }

        double speed(double meter, int round)
        {
            return Math.Round(meter / foot, round);
        }

        double staticSpine(double tradSpine, int round) //may require improvement
        {
            return tradSpine / spine;
        }

    }


}
