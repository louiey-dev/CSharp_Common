namespace CSharp_Common
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            statusStrip1 = new StatusStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            splitContainerMain = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage7 = new TabPage();
            tabControl2 = new TabControl();
            tabPage8 = new TabPage();
            tbListBoxRem = new Button();
            tbListBoxAdd = new Button();
            tbListBox = new TextBox();
            tbListViewRem = new Button();
            tbListViewAdd = new Button();
            tbListView = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            listView1 = new ListView();
            tabPage9 = new TabPage();
            tabPage6 = new TabPage();
            splitContainer1 = new SplitContainer();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox2 = new GroupBox();
            rbGridDash = new RadioButton();
            rbGridSolid = new RadioButton();
            rbGridDot = new RadioButton();
            rbGridNo = new RadioButton();
            rbGridDashDot = new RadioButton();
            cbSmartLabel = new CheckBox();
            cbYlabel = new CheckBox();
            cbXlabel = new CheckBox();
            btnChartClear = new Button();
            btnChartInit = new Button();
            btnChartGo2 = new Button();
            btnChartGo1 = new Button();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            groupBox1 = new GroupBox();
            rjToggleButton1 = new RJControls.RJToggleButton();
            splitContainerLog = new SplitContainer();
            richTextBoxLog = new RichTextBox();
            toolTip1 = new ToolTip(components);
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage7.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox2.SuspendLayout();
            tabPage5.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerLog).BeginInit();
            splitContainerLog.Panel1.SuspendLayout();
            splitContainerLog.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1 });
            statusStrip1.Location = new Point(0, 581);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1245, 30);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(40, 28);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            toolStripSplitButton1.ButtonClick += toolStripSplitButton1_ButtonClick;
            // 
            // splitContainerMain
            // 
            splitContainerMain.BorderStyle = BorderStyle.FixedSingle;
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.FixedPanel = FixedPanel.Panel2;
            splitContainerMain.Location = new Point(0, 0);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(splitContainerLog);
            splitContainerMain.Size = new Size(1245, 581);
            splitContainerMain.SplitterDistance = 810;
            splitContainerMain.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 579);
            tabControl1.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(tabControl2);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Margin = new Padding(2, 2, 2, 2);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(800, 551);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "ToolBox";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Controls.Add(tabPage9);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Margin = new Padding(2, 2, 2, 2);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(800, 551);
            tabControl2.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(tbListBoxRem);
            tabPage8.Controls.Add(tbListBoxAdd);
            tabPage8.Controls.Add(tbListBox);
            tabPage8.Controls.Add(tbListViewRem);
            tabPage8.Controls.Add(tbListViewAdd);
            tabPage8.Controls.Add(tbListView);
            tabPage8.Controls.Add(label2);
            tabPage8.Controls.Add(label1);
            tabPage8.Controls.Add(listBox1);
            tabPage8.Controls.Add(listView1);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Margin = new Padding(2, 2, 2, 2);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(2, 2, 2, 2);
            tabPage8.Size = new Size(792, 523);
            tabPage8.TabIndex = 0;
            tabPage8.Text = "ListView/Box";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tbListBoxRem
            // 
            tbListBoxRem.Location = new Point(282, 277);
            tbListBoxRem.Margin = new Padding(2, 2, 2, 2);
            tbListBoxRem.Name = "tbListBoxRem";
            tbListBoxRem.Size = new Size(78, 20);
            tbListBoxRem.TabIndex = 7;
            tbListBoxRem.Text = "Rem";
            tbListBoxRem.UseVisualStyleBackColor = true;
            // 
            // tbListBoxAdd
            // 
            tbListBoxAdd.Location = new Point(282, 253);
            tbListBoxAdd.Margin = new Padding(2, 2, 2, 2);
            tbListBoxAdd.Name = "tbListBoxAdd";
            tbListBoxAdd.Size = new Size(78, 20);
            tbListBoxAdd.TabIndex = 6;
            tbListBoxAdd.Text = "Add";
            tbListBoxAdd.UseVisualStyleBackColor = true;
            tbListBoxAdd.Click += tbListBoxAdd_Click;
            // 
            // tbListBox
            // 
            tbListBox.Location = new Point(282, 231);
            tbListBox.Margin = new Padding(2, 2, 2, 2);
            tbListBox.Name = "tbListBox";
            tbListBox.Size = new Size(185, 23);
            tbListBox.TabIndex = 5;
            // 
            // tbListViewRem
            // 
            tbListViewRem.Location = new Point(282, 82);
            tbListViewRem.Margin = new Padding(2, 2, 2, 2);
            tbListViewRem.Name = "tbListViewRem";
            tbListViewRem.Size = new Size(78, 20);
            tbListViewRem.TabIndex = 4;
            tbListViewRem.Text = "Rem";
            tbListViewRem.UseVisualStyleBackColor = true;
            tbListViewRem.Click += tbListViewRem_Click;
            // 
            // tbListViewAdd
            // 
            tbListViewAdd.Location = new Point(282, 58);
            tbListViewAdd.Margin = new Padding(2, 2, 2, 2);
            tbListViewAdd.Name = "tbListViewAdd";
            tbListViewAdd.Size = new Size(78, 20);
            tbListViewAdd.TabIndex = 4;
            tbListViewAdd.Text = "Add";
            tbListViewAdd.UseVisualStyleBackColor = true;
            tbListViewAdd.Click += tbListViewAdd_Click;
            // 
            // tbListView
            // 
            tbListView.Location = new Point(282, 35);
            tbListView.Margin = new Padding(2, 2, 2, 2);
            tbListView.Name = "tbListView";
            tbListView.Size = new Size(185, 23);
            tbListView.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 211);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "ListBox";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "ListView";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(11, 231);
            listBox1.Margin = new Padding(2, 2, 2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(268, 169);
            listBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new Point(11, 35);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(268, 144);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(4, 24);
            tabPage9.Margin = new Padding(2, 2, 2, 2);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(2, 2, 2, 2);
            tabPage9.Size = new Size(796, 546);
            tabPage9.TabIndex = 1;
            tabPage9.Text = "Select";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(splitContainer1);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(802, 563);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Chart";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(chart1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(cbSmartLabel);
            splitContainer1.Panel2.Controls.Add(cbYlabel);
            splitContainer1.Panel2.Controls.Add(cbXlabel);
            splitContainer1.Panel2.Controls.Add(btnChartClear);
            splitContainer1.Panel2.Controls.Add(btnChartInit);
            splitContainer1.Panel2.Controls.Add(btnChartGo2);
            splitContainer1.Panel2.Controls.Add(btnChartGo1);
            splitContainer1.Size = new Size(802, 563);
            splitContainer1.SplitterDistance = 496;
            splitContainer1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(802, 496);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbGridDash);
            groupBox2.Controls.Add(rbGridSolid);
            groupBox2.Controls.Add(rbGridDot);
            groupBox2.Controls.Add(rbGridNo);
            groupBox2.Controls.Add(rbGridDashDot);
            groupBox2.Location = new Point(511, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 47);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Major Grid";
            // 
            // rbGridDash
            // 
            rbGridDash.AutoSize = true;
            rbGridDash.Location = new Point(53, 22);
            rbGridDash.Name = "rbGridDash";
            rbGridDash.Size = new Size(52, 19);
            rbGridDash.TabIndex = 5;
            rbGridDash.Text = "Dash";
            rbGridDash.UseVisualStyleBackColor = true;
            rbGridDash.CheckedChanged += rbGridDash_CheckedChanged;
            // 
            // rbGridSolid
            // 
            rbGridSolid.AutoSize = true;
            rbGridSolid.Checked = true;
            rbGridSolid.Location = new Point(240, 26);
            rbGridSolid.Name = "rbGridSolid";
            rbGridSolid.Size = new Size(52, 19);
            rbGridSolid.TabIndex = 5;
            rbGridSolid.TabStop = true;
            rbGridSolid.Text = "Solid";
            rbGridSolid.UseVisualStyleBackColor = true;
            rbGridSolid.CheckedChanged += rbGridSolid_CheckedChanged;
            // 
            // rbGridDot
            // 
            rbGridDot.AutoSize = true;
            rbGridDot.Location = new Point(189, 24);
            rbGridDot.Name = "rbGridDot";
            rbGridDot.Size = new Size(45, 19);
            rbGridDot.TabIndex = 5;
            rbGridDot.Text = "Dot";
            rbGridDot.UseVisualStyleBackColor = true;
            rbGridDot.CheckedChanged += rbGridDot_CheckedChanged;
            // 
            // rbGridNo
            // 
            rbGridNo.AutoSize = true;
            rbGridNo.Location = new Point(6, 22);
            rbGridNo.Name = "rbGridNo";
            rbGridNo.Size = new Size(41, 19);
            rbGridNo.TabIndex = 5;
            rbGridNo.Text = "No";
            rbGridNo.UseVisualStyleBackColor = true;
            rbGridNo.CheckedChanged += rbGridNo_CheckedChanged;
            // 
            // rbGridDashDot
            // 
            rbGridDashDot.AutoSize = true;
            rbGridDashDot.Location = new Point(111, 23);
            rbGridDashDot.Name = "rbGridDashDot";
            rbGridDashDot.Size = new Size(72, 19);
            rbGridDashDot.TabIndex = 5;
            rbGridDashDot.Text = "DashDot";
            rbGridDashDot.UseVisualStyleBackColor = true;
            rbGridDashDot.CheckedChanged += rbGridDashDot_CheckedChanged;
            // 
            // cbSmartLabel
            // 
            cbSmartLabel.AutoSize = true;
            cbSmartLabel.Location = new Point(345, 10);
            cbSmartLabel.Name = "cbSmartLabel";
            cbSmartLabel.Size = new Size(90, 19);
            cbSmartLabel.TabIndex = 4;
            cbSmartLabel.Text = "Smart Label";
            cbSmartLabel.UseVisualStyleBackColor = true;
            cbSmartLabel.CheckedChanged += cbSmartLabel_CheckedChanged;
            // 
            // cbYlabel
            // 
            cbYlabel.AutoSize = true;
            cbYlabel.Location = new Point(248, 33);
            cbYlabel.Name = "cbYlabel";
            cbYlabel.Size = new Size(91, 19);
            cbYlabel.TabIndex = 3;
            cbYlabel.Text = "Count Label";
            cbYlabel.UseVisualStyleBackColor = true;
            cbYlabel.CheckedChanged += cbYlabel_CheckedChanged;
            // 
            // cbXlabel
            // 
            cbXlabel.AutoSize = true;
            cbXlabel.Location = new Point(248, 10);
            cbXlabel.Name = "cbXlabel";
            cbXlabel.Size = new Size(74, 19);
            cbXlabel.TabIndex = 3;
            cbXlabel.Text = "No Label";
            cbXlabel.UseVisualStyleBackColor = true;
            cbXlabel.CheckedChanged += cbXlabel_CheckedChanged;
            // 
            // btnChartClear
            // 
            btnChartClear.Location = new Point(7, 33);
            btnChartClear.Name = "btnChartClear";
            btnChartClear.Size = new Size(75, 23);
            btnChartClear.TabIndex = 2;
            btnChartClear.Text = "Clear";
            btnChartClear.UseVisualStyleBackColor = true;
            btnChartClear.Click += btnChartClear_Click;
            // 
            // btnChartInit
            // 
            btnChartInit.Location = new Point(7, 6);
            btnChartInit.Name = "btnChartInit";
            btnChartInit.Size = new Size(75, 23);
            btnChartInit.TabIndex = 1;
            btnChartInit.Text = "Chart Init";
            btnChartInit.UseVisualStyleBackColor = true;
            btnChartInit.Click += btnChartInit_Click;
            // 
            // btnChartGo2
            // 
            btnChartGo2.Enabled = false;
            btnChartGo2.Location = new Point(122, 33);
            btnChartGo2.Name = "btnChartGo2";
            btnChartGo2.Size = new Size(75, 23);
            btnChartGo2.TabIndex = 0;
            btnChartGo2.Text = "Go -";
            btnChartGo2.UseVisualStyleBackColor = true;
            btnChartGo2.Click += btnChartGo2_Click;
            // 
            // btnChartGo1
            // 
            btnChartGo1.Enabled = false;
            btnChartGo1.Location = new Point(122, 6);
            btnChartGo1.Name = "btnChartGo1";
            btnChartGo1.Size = new Size(75, 23);
            btnChartGo1.TabIndex = 0;
            btnChartGo1.Text = "Go +";
            btnChartGo1.UseVisualStyleBackColor = true;
            btnChartGo1.Click += btnChartGo1_Click;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(802, 563);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Serial";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(802, 563);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Socket";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(802, 563);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "FileIO";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(802, 563);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "CSV";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(groupBox1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(802, 563);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Switch/Button";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rjToggleButton1);
            groupBox1.Location = new Point(7, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 503);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Switch";
            // 
            // rjToggleButton1
            // 
            rjToggleButton1.AutoSize = true;
            rjToggleButton1.BackColor = Color.Transparent;
            rjToggleButton1.ForeColor = Color.Transparent;
            rjToggleButton1.Location = new Point(6, 22);
            rjToggleButton1.MinimumSize = new Size(45, 22);
            rjToggleButton1.Name = "rjToggleButton1";
            rjToggleButton1.OffBackColor = Color.Gray;
            rjToggleButton1.OffToggleColor = Color.Gainsboro;
            rjToggleButton1.OnBackColor = Color.Violet;
            rjToggleButton1.OnToggleColor = Color.WhiteSmoke;
            rjToggleButton1.Size = new Size(45, 22);
            rjToggleButton1.TabIndex = 1;
            rjToggleButton1.UseVisualStyleBackColor = false;
            // 
            // splitContainerLog
            // 
            splitContainerLog.BorderStyle = BorderStyle.FixedSingle;
            splitContainerLog.Dock = DockStyle.Fill;
            splitContainerLog.FixedPanel = FixedPanel.Panel2;
            splitContainerLog.Location = new Point(0, 0);
            splitContainerLog.Name = "splitContainerLog";
            splitContainerLog.Orientation = Orientation.Horizontal;
            // 
            // splitContainerLog.Panel1
            // 
            splitContainerLog.Panel1.Controls.Add(richTextBoxLog);
            splitContainerLog.Size = new Size(431, 581);
            splitContainerLog.SplitterDistance = 428;
            splitContainerLog.TabIndex = 0;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Dock = DockStyle.Fill;
            richTextBoxLog.Location = new Point(0, 0);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.Size = new Size(429, 426);
            richTextBoxLog.TabIndex = 0;
            richTextBoxLog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 611);
            Controls.Add(splitContainerMain);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            tabPage6.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainerLog.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerLog).EndInit();
            splitContainerLog.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private SplitContainer splitContainerMain;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private SplitContainer splitContainerLog;
        private ToolTip toolTip1;
        private TabPage tabPage5;
        private GroupBox groupBox1;
        private RJControls.RJToggleButton rjToggleButton1;
        private TabPage tabPage6;
        private SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btnChartGo1;
        private Button btnChartGo2;
        private Button btnChartInit;
        private Button btnChartClear;
        private CheckBox cbYlabel;
        private CheckBox cbXlabel;
        private CheckBox cbSmartLabel;
        private RadioButton rbGridNo;
        private RadioButton rbGridDashDot;
        private RadioButton rbGridDash;
        private RadioButton rbGridDot;
        private RadioButton rbGridSolid;
        private GroupBox groupBox2;
        public RichTextBox richTextBoxLog;
        private ToolStripSplitButton toolStripSplitButton1;
        private TabPage tabPage7;
        private TabControl tabControl2;
        private TabPage tabPage8;
        private Label label1;
        private ListBox listBox1;
        private ListView listView1;
        private TabPage tabPage9;
        private Label label2;
        private TextBox tbListView;
        private Button tbListBoxRem;
        private Button tbListBoxAdd;
        private TextBox tbListBox;
        private Button tbListViewRem;
        private Button tbListViewAdd;
    }
}
