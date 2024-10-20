using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BrovkinAA.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int n = Math.Abs(stopValue - startValue) + 1;
            double[] mass = new double[n];

            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Sin(startValue) + 2 == 0) mass[i] = 0;
                else
                {
                    mass[i] = (5 * startValue + 2.5) / (Math.Sin(startValue) + 2) + 2 * startValue + 2;
                    mass[i] = Math.Round(mass[i], 2);
                    startValue++;
                }

            }
            return mass;
        }
    }
}
