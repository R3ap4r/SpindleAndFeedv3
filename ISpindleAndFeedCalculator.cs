namespace SpindleAndFeedv3
{
    public interface ISpindleAndFeedCalculator
    {
        double Feed(double spindle, double aantalTand, double voedingTand);
        double Spindle(double freesDiameter, double vSnelheid);
    }
}