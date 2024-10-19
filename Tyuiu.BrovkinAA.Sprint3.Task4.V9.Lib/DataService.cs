using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BrovkinAA.Sprint3.Task4.V9.Lib
{
    public class DataService : ISprint3Task4V9
    {
        public double Calculate(int startValue, int stopValue)
        {
            double prod = 1;

            for (;startValue <= stopValue; startValue++)
            {
                if (startValue == 0) continue;

                prod *= startValue / (Math.Cos(startValue) - startValue);
            }

            return Math.Round(prod, 3);
        }
    }
}
