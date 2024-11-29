using System.Windows.Forms.DataVisualization.Charting;

namespace CSharp_Common
{
    public partial class Form1 : Form
    {
        double go1 = 0;
        double go2 = 10;
        double cCount = 0;

        CMyLog Log;
        CInvokeWrapper Iw;

        public Form1()
        {
            InitializeComponent();

            Log = new CMyLog(richTextBoxLog, 0x00ff, 100);
            Iw = new CInvokeWrapper();
        }

        private void btnChartGo1_Click(object sender, EventArgs e)
        {
            ChartSetXY(chart1, "No", cCount, go1++);
            if (go1 > 10) go1 = 0;

            ChartSetXY(chart1, "Count", cCount++, go2--);
            if (go2 == 0) go2 = 10;
        }

        private void btnChartGo2_Click(object sender, EventArgs e)
        {

        }

        private void btnChartInit_Click(object sender, EventArgs e)
        {
            ChartInit();
            btnChartGo1.Enabled = true;
            btnChartGo2.Enabled = true;
        }

        private void btnChartClear_Click(object sender, EventArgs e)
        {
            ChartClear(chart1);
        }

        private void cbXlabel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbXlabel.Checked)
                ChartLabelControl(chart1, "No", true);
            else
                ChartLabelControl(chart1, "No", false);
        }

        private void cbYlabel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYlabel.Checked)
                ChartLabelControl(chart1, "Count", true);
            else
                ChartLabelControl(chart1, "Count", false);
        }

        private void cbSmartLabel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSmartLabel.Checked)
            {
                chart1.Series["No"].SmartLabelStyle.Enabled = true;
                chart1.Series["Count"].SmartLabelStyle.Enabled = true;
            }
            else
            {
                chart1.Series["No"].SmartLabelStyle.Enabled = false;
                chart1.Series["Count"].SmartLabelStyle.Enabled = false;
            }
        }

        private void rbGridNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGridNo.Checked)
                ChartMajorGridStyle(chart1, ChartDashStyle.NotSet);
        }

        private void rbGridDash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGridDash.Checked)
                ChartMajorGridStyle(chart1, ChartDashStyle.Dash);
        }

        private void rbGridDashDot_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGridDashDot.Checked)
                ChartMajorGridStyle(chart1, ChartDashStyle.DashDot);
        }

        private void rbGridDot_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGridDot.Checked)
                ChartMajorGridStyle(chart1, ChartDashStyle.Dot);
        }

        private void rbGridSolid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGridSolid.Checked)
                ChartMajorGridStyle(chart1, ChartDashStyle.Solid);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Log.l("log button pressed\n");
            Log.e("error button pressed\n");
            Log.a("api button pressed\n");
            Log.w("warn button pressed\n");
            Log.i("info button pressed\n");
        }

        private void tbListViewAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String str = tbListView.Text + "\n";
                ListViewItem item = new ListViewItem(str);

                Iw.LVItemAdd(listView1, item);
            }
            catch (Exception ex)
            {
                Log.e(ex.Message);
            }
        }

        private void tbListViewRem_Click(object sender, EventArgs e)
        {
            try
            {
                //String str = tbListView.Text;
                //ListViewItem item = new ListViewItem(str);

                //int i = listView1.Items.IndexOf(str);

                //Iw.LVItemRem(listView1, listView1.Items[i]);
            }
            catch (Exception ex)
            {
                Log.e(ex.Message);
            }
        }

        private void tbListBoxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log.e(ex.Message);
            }
        }
    }
}
