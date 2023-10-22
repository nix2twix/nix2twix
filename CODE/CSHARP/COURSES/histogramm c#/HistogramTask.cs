using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var minDate = 2;
            var maxDate = 31;
            double[] birthsCounts = new double[31];

            foreach (var to in names)
            {
                if (to.Name == name && to.BirthDate.Day != 01) birthsCounts[to.BirthDate.Day-1]++;
            }

            var days = new string[31];

            for (var y = 0; y < days.Length; y++)
                days[y] = (y+1).ToString();

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                days, birthsCounts);
        }
    }
}