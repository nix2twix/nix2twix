using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            string[] dates = new string[30];
            for (int i = 0; i < dates.Length; i++)
                dates[i] = (i + 2).ToString();

            string[] monthsNames = new string[12];
            for (int i = 0; i < monthsNames.Length; i++)
                monthsNames[i] = (i + 1).ToString();

            double[,] heat = new double[30,12];
            foreach (var to in names)
            {
                if (to.BirthDate.Day != 01) heat[to.BirthDate.Day-2, to.BirthDate.Month-1]++;
            }
            return new HeatmapData(
                "Пример карты интенсивностей",
                heat,
                dates,
                monthsNames);
        }
    }
}