using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpindleAndFeedv3
{
    public class SpindleAndFeedCalculator : ISpindleAndFeedCalculator
    {
        public double Spindle(double freesDiameter, double vSnelheid)
        {
            double spindle = (vSnelheid * 1000) / (3.1415 * freesDiameter);

            return spindle;
        }

        public double Feed(double spindle, double aantalTand, double voedingTand)
        {
            double feed = spindle * aantalTand * voedingTand;

            return feed;
        }

    }

}
