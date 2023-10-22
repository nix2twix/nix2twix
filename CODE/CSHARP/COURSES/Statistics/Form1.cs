using System;
using ZedGraph;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics
{
    public partial class Form1 : Form
    {
        int tickStart = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void draw(double setpoint1, double setpoint2)
        {
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem curve2 = zedGraphControl1.GraphPane.CurveList[1] as LineItem;
            if (curve1 == null) return;
            if (curve2 == null) return;

            IPointListEdit list1 = curve1.Points as IPointListEdit;
            IPointListEdit list2 = curve2.Points as IPointListEdit;

            if (list1 == null) return;
            if (list2 == null) return;

            double time = (Environment.TickCount - tickStart) / 1000.0;

            list1.Add(time, setpoint1);
            list2.Add(time, Math.Sin(2.0*Math.PI*time/3.0));

            Scale xscale = zedGraphControl1.GraphPane.XAxis.Scale;
            if (time > xscale.Max - xscale.MajorStep)
            { }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            draw(5, 20);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GraphPane mypane = zedGraphControl1.GraphPane;
            mypane.Title.Text = "График демографии по годам";
            mypane.XAxis.Title.Text = "Года";
            mypane.YAxis.Title.Text = "Численность";
            RollingPointPairList list1 = new RollingPointPairList(1200);
            RollingPointPairList list2 = new RollingPointPairList(1200);
            LineItem curve1 = mypane.AddCurve("line1", list1, Color.Red, SymbolType.None);
            LineItem curve2 = mypane.AddCurve("line2", list2, Color.Blue, SymbolType.None);

            timer1.Interval =
            mypane.XAxis.Scale.Min = 0;
            mypane.XAxis.Scale.Max = 30;
            mypane.XAxis.Scale.MinorStep = 1;
            mypane.XAxis.Scale.MajorStep = 1;

            zedGraphControl1.AxisChange();

            tickStart = Environment.TickCount;
        }
    }
}
