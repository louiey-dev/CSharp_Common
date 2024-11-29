#define CHART_ENABLED

using System.Collections;
using System.Diagnostics;


#if CHART_ENABLED
using System.Windows.Forms.DataVisualization.Charting;
#endif

namespace CSharp_Common
{
    public partial class Form1 : Form
    {
#if CHART_ENABLED
        public void ChartSetXY(Chart ch, string series, double x, double y)
        {
            try
            {
                if (ch.InvokeRequired)
                {
                    ch.Invoke(new MethodInvoker(delegate ()
                    {
                        ch.Series[series].Points.AddXY(x, y);
                        ch.Invalidate();
                    }));
                }
                else
                {
                    ch.Series[series].Points.AddXY(x, y);
                    ch.Invalidate();
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        public void ChartSetY(Chart ch, string series, double y)
        {
            try
            {
                if (ch.InvokeRequired)
                {
                    ch.Invoke(new MethodInvoker(delegate ()
                    {
                        ch.Series[series].Points.AddY(y);
                        ch.Invalidate();
                    }));
                }
                else
                {
                    ch.Series[series].Points.AddY(y);
                    ch.Invalidate();
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        /// <summary>
        /// Display value at XY
        /// </summary>
        /// <param name="ch"></param>
        /// <param name="series"></param>
        /// <param name="onoff"></param>
        public void ChartLabelControl(Chart ch, String series, bool onoff)
        {
            try
            {
                if (ch.InvokeRequired)
                {
                    ch.Invoke(new MethodInvoker(delegate ()
                    {
                        ch.Series[series].IsValueShownAsLabel = onoff;
                    }));
                }
                else
                {
                    ch.Series[series].IsValueShownAsLabel = onoff;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        public void ChartClear(Chart ch)
        {
            try
            {
                if (ch.InvokeRequired)
                {
                    ch.Invoke(new MethodInvoker(delegate ()
                    {
                        foreach (var series in ch.Series)
                        {
                            series.Points.Clear();
                        }
                    }));
                }
                else
                {
                    foreach (var series in ch.Series)
                    {
                        series.Points.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        public void ChartMajorGridStyle(Chart ch, ChartDashStyle style)
        {
            try
            {
                if (ch.InvokeRequired)
                {
                    ch.Invoke(new MethodInvoker(delegate ()
                    {
                        ch.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = style;
                        ch.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = style;
                    }));
                }
                else
                {
                    ch.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = style;
                    ch.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = style;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }
#endif
    }
}
