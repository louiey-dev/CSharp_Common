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
                String str = tbListViewData.Text + "\n";
                ListViewItem item = new ListViewItem(str);

                Iw.LVItemAdd(listView1, item);
            }
            catch (Exception ex)
            {
                Log.e(ex.Message);
            }
        }

        //private void tbListViewRem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //String str = tbListView.Text;
        //        //ListViewItem item = new ListViewItem(str);

        //        //int i = listView1.Items.IndexOf(str);

        //        //Iw.LVItemRem(listView1, listView1.Items[i]);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.e(ex.Message);
        //    }
        //}

        //private void tbListBoxAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.e(ex.Message);
        //    }
        //}

        private void btnListViewColAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbColName.Text == null)
                {
                    MessageBox.Show("Please input column name");
                    return;
                }
                listView1.BeginUpdate();

                String str = Iw.TBGet(tbColName);
                Iw.LVColAdd(listView1, str);

                Iw.TBSet(tbColName, "");

                listView1.EndUpdate();
            }
            catch (Exception ex)
            {
                Log.e(ex.Message);
            }
        }

        private void btnListViewInit_Click(object sender, EventArgs e)
        {
            ListViewInit(listView1);
        }

        private void btnListViewColRem_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(tbListViewColIndex.Text);
            listView1.BeginUpdate();
            Iw.LVColRem(listView1, index);
            listView1.EndUpdate();
        }

        private void btnListViewColInsert_Click(object sender, EventArgs e)
        {
            if (tbListViewColIndex.Text == null)
            {
                MessageBox.Show("Please input number");
                return;
            }
            listView1.BeginUpdate();
            int index = Convert.ToInt32(tbListViewColIndex.Text);
            String str = Iw.TBGet(tbListViewColIndex);
            Iw.LVColInsert(listView1, str, index);
            listView1.EndUpdate();
        }

        private void tbColName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자와 백스페이스만 입력
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void btnListViewDataAdd_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();

            int idx = listView1.Items.Count;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item" + idx, 0);
            // Place a check mark next to the item.
            //item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");

            Iw.LVItemAdd(listView1, item1);

            listView1.EndUpdate();
        }

        private void rbListViewTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbListViewDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbListViewList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void btnListViewDataRem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();

            //선택한 index를 찾아서 그 인덱스를 지우면 된다.
            var selIdx = listView1.SelectedIndices;

            if (selIdx.Count > 0)
                Iw.LVItemRemAt(listView1, selIdx[0]);

            listView1.EndUpdate();
        }

        private void btnListBoxItemAdd_Click(object sender, EventArgs e)
        {
            String str = Iw.TBGet(tbListBoxItem);

            Iw.LBItemAdd(listBox1, str);
        }

        private void btnListBoxItemRem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            Iw.LBItemRemAt(listBox1, index);
        }

        private void btnListBoxInit_Click(object sender, EventArgs e)
        {
            Iw.LBItemAdd(listBox1, "apple");
            Iw.LBItemAdd(listBox1, "mango");
            Iw.LBItemAdd(listBox1, "pear");
            Iw.LBItemAdd(listBox1, "banana");
        }

        private void btnListBoxItemInsert_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(Iw.TBGet(tbListBoxItemIndex));
            String str = Iw.TBGet(tbListBoxItem);

            Iw.LBItemInsert(listBox1, str, index);
        }

        private void btnListBoxItemInsertSelected_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            String str = Iw.TBGet(tbListBoxItem);

            Iw.LBItemInsert(listBox1, str, index);
        }


        private void btnChartSeriesAdd_Click(object sender, EventArgs e)
        {
            //ChartSeriesAdd(chart1, charSeries[chartSeriesIdx], charSeriesName[chartSeriesIdx], SeriesChartType.Line, Color.Black, ChartDashStyle.Dash, 3);
        }

        private void btnTermCom_Click(object sender, EventArgs e)
        {
            TermUartCom(cbbTermComPort);
        }

        private void btnTermComOpenClose_Click(object sender, EventArgs e)
        {
            TermUartComOpen();
        }

        private void tbPuttyCmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPuttyCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (puttyCmdStreamWriter != null)
                {
                    try
                    {
                        string str = TBGet(tbPuttyCmd);
                        puttyCmdStreamWriter.WriteLine(str);
                        DBG(str);

                        TBSet(tbPuttyCmd, "");
                    }
                    catch (Exception ex)
                    {
                        ERR(ex.Message);
                    }
                }
            }
        }

        private void richTextBoxTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
#if false
            if (e.KeyChar == '\r')
            {
                if (puttyCmdStreamWriter != null)
                {
                    try
                    {
                        //string str = richTextBoxTerm.Lines.LastOrDefault() ?? string.Empty;
                        string str = richTextBoxTerm.Lines[richTextBoxTerm.Lines.Length - 2] ?? string.Empty;
                        puttyCmdStreamWriter.WriteLine(str);
                        DBG(str);
                    }
                    catch (Exception ex)
                    {
                        ERR(ex.Message);
                    }
                }
            }
#else
            // 키 입력의 기본 동작(에코) 방지
            //e.Handled = true;
            puttyCmdStreamWriter.Write(e.KeyChar.ToString());
#endif
        }

        private void richTextBoxTerm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    // ctrl+c key 처리
                    e.IsInputKey = true; // 기본 동작 방지
                    puttyCmdStreamWriter.Write(new char[] { (char)(0x03) }, 0, 1);
                }
                else if (e.KeyCode == Keys.Tab)
                {
                    // Tab 키 처리 로직
                    //puttyCmdStreamWriter.Write(0x09);
                    puttyCmdStreamWriter.Write(new char[] { (char)(0x09) }, 0, 1);
                    //new byte[] { 0x09 }, 0, 1

                    e.IsInputKey = true; // 기본 동작 방지
                }
                else if (e.KeyCode == Keys.Back)
                {
                    e.IsInputKey = true; // Prevent further processing of this key

                    // Handle backspace key press
                    // For example, you might want to remove the last character from the text
                    // 현재 커서의 인덱스를 가져옵니다.
                    int currentIndex = richTextBoxTerm.SelectionStart;

                    // 현재 인덱스에 해당하는 라인 번호를 구합니다.
                    int currentLine = richTextBoxTerm.GetLineFromCharIndex(currentIndex);

                    // 해당 라인의 텍스트를 가져옵니다.
                    string lineText = richTextBoxTerm.Lines[currentLine];

                    if (lineText.Length > 0)
                    {
                        DBG(lineText);
                        lineText = lineText.Substring(0, lineText.Length - 1);
                        DBG(lineText);
                        //richTextBoxTerminal.SelectionStart = lineText.Length; // Set cursor at the end
                        richTextBoxTerm.Lines[currentLine] = lineText;
                        //richTextBoxTerminal.SelectionStart = richTextBoxTerminal.SelectionStart - 1; // Set cursor at the end
                    }
                }
                //else if (e.KeyCode == Keys.Escape)
                //{
                //    e.IsInputKey = true;
                //}
                //else if (e.KeyCode == Keys.LineFeed)
                //{
                //    e.IsInputKey = true;
                //}
            }
            catch (Exception err)
            {
                ERR(err.ToString());
            }
        }
    }
}
