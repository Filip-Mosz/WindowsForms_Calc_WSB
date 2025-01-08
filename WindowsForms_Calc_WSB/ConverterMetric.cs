using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Calc_WSB
{
    internal class ConverterMetric
    {
        /*
         Object contining methods returning values in SI units
         */

        double foot = 30.48;
        double pound = 0.45359237;
        double grain = 0.06479891;
        double spine = 1; //find correct ratio

        public ConverterMetric() { }

        double poundage(double pounds, int round)
        {
            return Math.Round(pounds / pound, round);
        }

        double weight(double grains, int round)
        {
            return Math.Round(grains / grain, round);
        }

        double speed(double feet, int round)
        {
            return Math.Round(feet / foot, round);
        }

        double staticSpine(double tradSpine, int round) //may require improvement
        {
            return tradSpine / spine;
        }
    }
}
