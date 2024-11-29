using System.Windows.Forms.DataVisualization.Charting;

namespace CSharp_Common
{
    public partial class Form1 : Form
    {
        Series chartNo = null;
        Series chartCount = null;

        public void ChartInit()
        {
            try
            {
                Series chartNo = chart1.Series.Add("No");
                Series chartCount = chart1.Series.Add("Count");

                chart1.BorderlineDashStyle = ChartDashStyle.DashDot;

                chartNo.ChartType = SeriesChartType.Point;
                chart1.Series["No"].Color = System.Drawing.Color.Red;
                chart1.Series["No"].MarkerStyle = MarkerStyle.Triangle;
                chart1.Series["No"].MarkerSize = 5;
                //chart1.Series["No"].IsValueShownAsLabel = true;

                //chart1.ChartAreas[0].BorderDashStyle = ChartDashStyle.DashDot;
                //chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                //chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

                chartCount.ChartType = SeriesChartType.Line;
                chart1.Series["Count"].Color = System.Drawing.Color.Green;
                chart1.Series["Count"].BorderWidth = 2;
                chart1.Series["Count"].BorderDashStyle = ChartDashStyle.Dash;
                //chart1.Series["Count"].IsValueShownAsLabel = true;

            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
        }

        public void ChartUpdate()
        {
            try
            {

            }
            catch (Exception e)
            {
                ERR(e.ToString());
            }
        }
    }
}
