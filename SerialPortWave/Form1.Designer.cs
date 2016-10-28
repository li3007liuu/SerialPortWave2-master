namespace SerialPortWave
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receDis = new System.Windows.Forms.TextBox();
            this.receNumText = new System.Windows.Forms.Label();
            this.timeSendFlag = new System.Windows.Forms.CheckBox();
            this.sendCmdButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sendText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendTime = new System.Windows.Forms.TextBox();
            this.textBaud = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.findport = new System.Windows.Forms.Button();
            this.openCom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.串口号 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textDatanum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.Label();
            this.selectPath = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearChart = new System.Windows.Forms.Button();
            this.setChartButton = new System.Windows.Forms.Button();
            this.yLabel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zGraphTest = new Pengpai.UI.ZGraph();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.30556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.63492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.zGraphTest, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.receDis);
            this.groupBox1.Controls.Add(this.receNumText);
            this.groupBox1.Controls.Add(this.timeSendFlag);
            this.groupBox1.Controls.Add(this.sendCmdButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sendText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sendTime);
            this.groupBox1.Controls.Add(this.textBaud);
            this.groupBox1.Controls.Add(this.sendbutton);
            this.groupBox1.Controls.Add(this.findport);
            this.groupBox1.Controls.Add(this.openCom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.串口号);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // receDis
            // 
            this.receDis.Font = new System.Drawing.Font("微软雅黑 Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receDis.Location = new System.Drawing.Point(272, 20);
            this.receDis.Multiline = true;
            this.receDis.Name = "receDis";
            this.receDis.Size = new System.Drawing.Size(157, 41);
            this.receDis.TabIndex = 14;
            // 
            // receNumText
            // 
            this.receNumText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receNumText.Location = new System.Drawing.Point(435, 31);
            this.receNumText.Name = "receNumText";
            this.receNumText.Size = new System.Drawing.Size(52, 24);
            this.receNumText.TabIndex = 13;
            // 
            // timeSendFlag
            // 
            this.timeSendFlag.AutoSize = true;
            this.timeSendFlag.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeSendFlag.Location = new System.Drawing.Point(262, 112);
            this.timeSendFlag.Name = "timeSendFlag";
            this.timeSendFlag.Size = new System.Drawing.Size(15, 14);
            this.timeSendFlag.TabIndex = 12;
            this.timeSendFlag.UseVisualStyleBackColor = true;
            // 
            // sendCmdButton
            // 
            this.sendCmdButton.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendCmdButton.Location = new System.Drawing.Point(416, 66);
            this.sendCmdButton.Name = "sendCmdButton";
            this.sendCmdButton.Size = new System.Drawing.Size(68, 30);
            this.sendCmdButton.TabIndex = 11;
            this.sendCmdButton.Text = "发送";
            this.sendCmdButton.UseVisualStyleBackColor = true;
            this.sendCmdButton.Click += new System.EventHandler(this.sendCmdButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(208, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "命令:";
            // 
            // sendText
            // 
            this.sendText.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendText.Location = new System.Drawing.Point(272, 67);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(139, 29);
            this.sendText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(208, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "接收区:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(371, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ms";
            // 
            // sendTime
            // 
            this.sendTime.Location = new System.Drawing.Point(283, 104);
            this.sendTime.Name = "sendTime";
            this.sendTime.Size = new System.Drawing.Size(84, 29);
            this.sendTime.TabIndex = 1;
            this.sendTime.TextChanged += new System.EventHandler(this.sendTime_TextChanged);
            // 
            // textBaud
            // 
            this.textBaud.Location = new System.Drawing.Point(69, 65);
            this.textBaud.Name = "textBaud";
            this.textBaud.Size = new System.Drawing.Size(131, 29);
            this.textBaud.TabIndex = 6;
            this.textBaud.TextChanged += new System.EventHandler(this.textBaud_TextChanged);
            // 
            // sendbutton
            // 
            this.sendbutton.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendbutton.Location = new System.Drawing.Point(404, 103);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(80, 30);
            this.sendbutton.TabIndex = 0;
            this.sendbutton.Text = "开始采集";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // findport
            // 
            this.findport.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findport.Location = new System.Drawing.Point(5, 102);
            this.findport.Name = "findport";
            this.findport.Size = new System.Drawing.Size(78, 31);
            this.findport.TabIndex = 5;
            this.findport.Text = "搜索";
            this.findport.UseVisualStyleBackColor = true;
            this.findport.Click += new System.EventHandler(this.findport_Click);
            // 
            // openCom
            // 
            this.openCom.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openCom.Location = new System.Drawing.Point(89, 102);
            this.openCom.Name = "openCom";
            this.openCom.Size = new System.Drawing.Size(111, 31);
            this.openCom.TabIndex = 4;
            this.openCom.Text = "打开串口";
            this.openCom.UseVisualStyleBackColor = true;
            this.openCom.Click += new System.EventHandler(this.openCom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率:";
            // 
            // 串口号
            // 
            this.串口号.AutoSize = true;
            this.串口号.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.串口号.Location = new System.Drawing.Point(1, 32);
            this.串口号.Name = "串口号";
            this.串口号.Size = new System.Drawing.Size(62, 21);
            this.串口号.TabIndex = 2;
            this.串口号.Text = "串口号:";
            // 
            // port
            // 
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(69, 28);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(131, 30);
            this.port.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textDatanum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.filePath);
            this.groupBox2.Controls.Add(this.selectPath);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(500, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件保存配置";
            // 
            // textDatanum
            // 
            this.textDatanum.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textDatanum.Location = new System.Drawing.Point(10, 102);
            this.textDatanum.Name = "textDatanum";
            this.textDatanum.Size = new System.Drawing.Size(100, 26);
            this.textDatanum.TabIndex = 3;
            this.textDatanum.TextChanged += new System.EventHandler(this.textDatanum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "单个文件数据总数";
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filePath.Location = new System.Drawing.Point(89, 34);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(46, 20);
            this.filePath.TabIndex = 1;
            this.filePath.Text = "label4";
            // 
            // selectPath
            // 
            this.selectPath.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectPath.Location = new System.Drawing.Point(7, 29);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(75, 29);
            this.selectPath.TabIndex = 0;
            this.selectPath.Text = "选择";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearChart);
            this.groupBox3.Controls.Add(this.setChartButton);
            this.groupBox3.Controls.Add(this.yLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.xLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(708, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 139);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "波形图操作";
            // 
            // clearChart
            // 
            this.clearChart.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearChart.Location = new System.Drawing.Point(19, 102);
            this.clearChart.Name = "clearChart";
            this.clearChart.Size = new System.Drawing.Size(166, 31);
            this.clearChart.TabIndex = 7;
            this.clearChart.Text = "清除波形";
            this.clearChart.UseVisualStyleBackColor = true;
            this.clearChart.Click += new System.EventHandler(this.clearChart_Click);
            // 
            // setChartButton
            // 
            this.setChartButton.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setChartButton.Location = new System.Drawing.Point(204, 25);
            this.setChartButton.Name = "setChartButton";
            this.setChartButton.Size = new System.Drawing.Size(75, 69);
            this.setChartButton.TabIndex = 6;
            this.setChartButton.Text = "设置";
            this.setChartButton.UseVisualStyleBackColor = true;
            this.setChartButton.Click += new System.EventHandler(this.setChartButton_Click);
            // 
            // yLabel
            // 
            this.yLabel.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yLabel.Location = new System.Drawing.Point(85, 65);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(100, 29);
            this.yLabel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(15, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "y轴标签";
            // 
            // xLabel
            // 
            this.xLabel.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xLabel.Location = new System.Drawing.Point(85, 28);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(100, 26);
            this.xLabel.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(15, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "x轴标签";
            // 
            // zGraphTest
            // 
            this.zGraphTest.AllowDrop = true;
            this.zGraphTest.BackColor = System.Drawing.Color.White;
            this.zGraphTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.zGraphTest, 3);
            this.zGraphTest.Location = new System.Drawing.Point(0, 232);
            this.zGraphTest.m_backColorH = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.zGraphTest.m_backColorL = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.zGraphTest.m_BigXYBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.zGraphTest.m_ControlButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zGraphTest.m_ControlButtonForeColorH = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.zGraphTest.m_ControlButtonForeColorL = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.zGraphTest.m_ControlItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zGraphTest.m_coordinateLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zGraphTest.m_coordinateStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zGraphTest.m_coordinateStringTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zGraphTest.m_DirectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.zGraphTest.m_DirectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.zGraphTest.m_fXBeginSYS = 0F;
            this.zGraphTest.m_fXEndSYS = 1000F;
            this.zGraphTest.m_fYBeginSYS = 0F;
            this.zGraphTest.m_fYEndSYS = 1F;
            this.zGraphTest.m_GraphBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zGraphTest.m_iLineShowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.zGraphTest.m_iLineShowColorAlpha = 100;
            this.zGraphTest.m_ShowNumBackColor = System.Drawing.Color.White;
            this.zGraphTest.m_ShowNumForeClor = System.Drawing.Color.Yellow;
            this.zGraphTest.m_SySnameX = "时间";
            this.zGraphTest.m_SySnameY = "电压";
            this.zGraphTest.m_SyStitle = "";
            this.zGraphTest.m_titleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.zGraphTest.m_titleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zGraphTest.m_titlePosition = 0.4F;
            this.zGraphTest.m_titleSize = 14;
            this.zGraphTest.Margin = new System.Windows.Forms.Padding(0);
            this.zGraphTest.MinimumSize = new System.Drawing.Size(390, 270);
            this.zGraphTest.Name = "zGraphTest";
            this.zGraphTest.Size = new System.Drawing.Size(1008, 360);
            this.zGraphTest.TabIndex = 2;
            this.zGraphTest.Load += new System.EventHandler(this.zGraph1_Load);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(336, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口信号采集示波器";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 640);
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口信号采集示波器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Pengpai.UI.ZGraph zGraphTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 串口号;
        private System.Windows.Forms.ComboBox port;
        private System.Windows.Forms.Button findport;
        private System.Windows.Forms.TextBox textBaud;
        private System.Windows.Forms.TextBox sendTime;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.TextBox textDatanum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendCmdButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button setChartButton;
        private System.Windows.Forms.TextBox yLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xLabel;
        private System.Windows.Forms.CheckBox timeSendFlag;
        private System.Windows.Forms.Button clearChart;
        private System.Windows.Forms.Label receNumText;
        private System.Windows.Forms.TextBox receDis;
    }
}

