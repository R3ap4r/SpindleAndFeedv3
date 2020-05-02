using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpindleAndFeedv3
{
    public static class Factory
    {
        public static ISpindleAndFeedCalculator SpindleAndFeed()
        {
            return new SpindleAndFeedCalculator();
        }
    }
}
