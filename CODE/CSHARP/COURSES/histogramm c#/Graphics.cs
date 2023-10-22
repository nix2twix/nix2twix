using System.Linq;

namespace Names
{
    public class Graphics
    {
        public Graphics(string title, string[] xLabels, double[] yValues)
        {
            Title = title;
            XLabels = xLabels;
            YValues = yValues;
        }

        public string Title { get; }
        public string[] XLabels { get; }
        public double[] YValues { get; }

        public bool Equals(Graphics other)
        {
            return other.XLabels.SequenceEqual(XLabels) && other.YValues.SequenceEqual(YValues);
        }
    }
}