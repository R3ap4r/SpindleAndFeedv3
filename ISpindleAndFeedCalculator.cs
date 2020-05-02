namespace SpindleAndFeedv3
{
    public interface ISpindleAndFeedCalculator
    {
        /// <summary>
        /// Calculates the Feed rate, takes 3 params.
        /// </summary>
        /// <remarks>spindle, aantalTand, voedingTand</remarks>
        /// <returns>Double</returns>
        double Feed(double spindle, double aantalTand, double voedingTand);
        /// <summary>
        /// Calculates the Spindle speed, takes 2 params
        /// </summary>
        /// <remarks>
        /// freesDiameter
        /// vSnelheid
        /// </remarks>
        /// <returns>Double</returns>
        double Spindle(double freesDiameter, double vSnelheid);
    }
}