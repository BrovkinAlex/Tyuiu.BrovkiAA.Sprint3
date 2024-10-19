using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BrovkinAA.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            while (startValue <= stopValue)
            {
                sum += Math.Pow(1 / (startValue + Math.Pow(5, startValue)), startValue);
                startValue++;
            }

            return Math.Round(sum, 3);
        }
    }
}
