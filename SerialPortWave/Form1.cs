using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Xml;
using System.Threading;

namespace SerialPortWave
{
    public partial class FormMain : Form
    {
        StreamWriter sw;
        private SerialPort comm = new SerialPort();
        private String cpath = @"config.xml";
        private StringBuilder builder = new StringBuilder();
        private StringBuilder builder2 = new StringBuilder();
        private System.Timers.Timer tmr = new System.Timers.Timer();
        private byte[] fifoA;
        private byte[] fifoB;
        private int bytenum = 6000;
        private int bytecount;
        private bool fifoflag;
        private bool disflag;
        private Thread thread;
        private bool writeflag;
        private bool reChartUpdate;
        private byte[] cmdData;//命令发送字符数组
        private bool cmdDataSend;//命令发送字符标记位
        private bool psetSucess;
        private List<byte> byteFifo= new List<byte>();
        private List<byte> temp3 = new List<byte>();
        private long errorCount;
        private bool Listening = false;
        private bool Closing = false;

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //初始化下拉串口名称列表框
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            port.Items.AddRange(ports);
            port.SelectedIndex = port.Items.Count > 0 ? 0 : -1;

            //初始化SerialPort对象
            comm.NewLine = "\r\n";
            comm.RtsEnable = true;

            //添加事件注册
            comm.DataReceived += comm_DataReceived;

            getFromXml();

            sendbutton.Enabled = false;
            sendCmdButton.Enabled = false;
            disflag = false;
            reChartUpdate = false;
            errorCount = 0;

            timerDrawI = 0;
            x1.Clear();
            y1.Clear();
            x2.Clear();
            y2.Clear();
            zGraphTest.f_ClearAllPix();
            zGraphTest.f_reXY();
            zGraphTest.f_InitMode(Pengpai.UI.ZGraph.GraphStyle.DefaultMoveMode);
            zGraphTest.f_LoadOnePix(x1, y1, Color.Purple, 2);
            zGraphTest.f_AddPix(x2, y2, Color.Red, 2);


            label1.ForeColor = Color.Black;
            tmr.Elapsed += new System.Timers.ElapsedEventHandler(tmr_Elapsed);

            thread = new Thread(writeDataToFile);
            thread.Start();
        }
        public List<float> x1 = new List<float>();
        public List<float> y1 = new List<float>();
        public List<float> x2 = new List<float>();
        public List<float> y2 = new List<float>();
        private int timerDrawI = 0;
        Random rand = new Random();

        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Closing)
                return;
            try
            {
                Listening = true;
                int n = comm.BytesToRead;
                byte[] buf = new byte[n];
                comm.Read(buf, 0, n);
                if (n > 0)
                {
                    //将数据放入list中
                    for (int i = 0; i < n; i++)
                    {
                        byteFifo.Add(buf[i]);
                    }


                }
                //如果list中数据大于600 则进行集中处理
                if (byteFifo.Count() > 200)
                {
                    bool temp2 = false;
                    temp3.Clear();
                    int count = 0;
                    for (int i = 0; (i + 5) < byteFifo.Count();)
                    {
                        if ((byteFifo.ElementAt(i)&0x7f) == 0x77 && byteFifo.ElementAt(i + 5) == 0x99)
                        {
                            if(byteFifo.ElementAt(i)>0x80)
                            {
                                label1.ForeColor = Color.Red;
                            }
                            else
                            {
                                label1.ForeColor = Color.Black;
                            }
                            temp2 = false;
                            if (disflag == true)
                            {
                                addDataToChart(byteFifo.ElementAt(i + 1), byteFifo.ElementAt(i + 2), byteFifo.ElementAt(i + 3), byteFifo.ElementAt(i + 4));
                            }
                            addDataToBuffer(byteFifo.ElementAt(i + 1), byteFifo.ElementAt(i + 2), byteFifo.ElementAt(i + 3), byteFifo.ElementAt(i + 4));
                            i = i + 6;
                        }
                        else
                        {

                            if (byteFifo.ElementAt(i) == 0xfe && (byteFifo.ElementAt(i - 1) == 0x99 && i >= 1))
                            {
                                temp2 = true;
                                psetSucess = true;

                            }
                            else
                            {
                                if (i > 8)
                                {
                                    errorCount++;
                                }
                            }
                            if (temp2 == true)
                            {
                                temp3.Add(byteFifo.ElementAt(i));
                            }
                            i++;
                        }
                        count = i;
                    }
                    //移除list中数据留下6个
                    for (int l = 0; l < (count - 6); l++)
                    {
                        byteFifo.RemoveAt(0);
                    }
                }
                if (cmdDataSend == true)
                {
                    cmdDataSend = false;
                    comm.Write(cmdData, 0, cmdData.Length);
                }
                builder.Clear();

                this.Invoke((EventHandler)(delegate
                {

                    if (psetSucess == true)
                    {
                        byte[] disError = temp3.ToArray();
                        foreach (byte b in disError)
                        {
                            builder.Append(b.ToString("X2") + " ");
                        }
                        psetSucess = false;
                        this.receDis.Text = builder.ToString();
                    //this.sendText.Text = setSucessS + "Set Sucess!";
                }

                    this.receNumText.Text = errorCount.ToString();
                    if (disflag == true && reChartUpdate == true)
                        reChartUpdate = false;
                    this.zGraphTest.f_Refresh();
                }));
            }
            finally
            {
                Listening = false;
            }           
        }

        void writeDataToFile()
        {
            while(true)
            {
                if(writeflag==true)
                {
                    writeflag = false;
                    String filename = filePath.Text + "\\" + "data"
                             + DateTime.Now.Year.ToString("0000") + "-" + DateTime.Now.Month.ToString("00") + "-"
                             + DateTime.Now.Day.ToString("00") + "_" + DateTime.Now.Hour.ToString("00")
                             + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00") + ".dat";
                    builder2.Clear();
                    if(fifoflag==true)
                    {
                        foreach(byte i in fifoA)
                        {
                            builder2.Append(i.ToString("X2") + " ");
                        }
                    }
                    else
                    {
                        foreach (byte i in fifoB)
                        {
                            builder2.Append(i.ToString("X2") + " ");
                        }
                    }
                    using (sw = new StreamWriter(filename, true, Encoding.Default))
                    //向创建的文件中写入内容
                    {
                        sw.Write(builder2.ToString());
                        //关闭当前文件写入流
                        sw.Close();
                    }
                }
                else
                {
                    Thread.Sleep(500);
                }
            }
        }
        private void findport_Click(object sender, EventArgs e)
        {
            //初始化下拉串口名称列表框
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            port.Items.Clear();
            port.Items.AddRange(ports);
            port.SelectedIndex = port.Items.Count > 0 ? 0 : -1;
        }
        private void openCom_Click(object sender, EventArgs e)
        {
            if(openCom.Text.ToString()=="关闭串口")
            {
                Closing = true;
                while (Listening)
                    Application.DoEvents();
                comm.Close();
                Closing = false;
                findport.Enabled = true;
                sendbutton.Enabled = false;
                selectPath.Enabled = true;
                sendCmdButton.Enabled = false;
            }
            else
            {
                int baudrate = 0;
                if (textBaud.Text!=null&&textBaud.Text!="")
                {
                    baudrate = int.Parse(textBaud.Text);
                }

                if(baudrate>0&& port.Text!=null)
                {
                    comm.PortName = port.Text;
                    comm.BaudRate = baudrate;
                    comm.ReadTimeout = 1;
                    try
                    {
                        comm.Open();
                        findport.Enabled = false;
                        sendbutton.Enabled = true;
                        selectPath.Enabled = false;
                        sendCmdButton.Enabled = true;

                        if (textDatanum.Text != null && textDatanum.Text != "")
                        {
                            bytenum = int.Parse(textDatanum.Text);
                        }
                        fifoA = new byte[ bytenum* 4];
                        fifoB = new byte[ bytenum* 4];
                        bytecount = 0;
                        fifoflag = false;

                    }
                    catch(Exception ex)
                    {
                        //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                        comm = new SerialPort();
                        //现实异常信息给客户。
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("请选择正确的端口号或填写正确的波特率", "操作错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            openCom.Text = comm.IsOpen ? "关闭串口" : "打开串口";
            
            
        }

        private void zGraph1_Load(object sender, EventArgs e)
        {

        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (disflag==false)
            {
  
                sendbutton.Text = "停止采集";
                disflag = true;
                openCom.Enabled = false;

                tmr.Interval = int.Parse(sendTime.Text);
                if (timeSendFlag.Checked == true)
                {
                    tmr.Start();
                }
                timeSendFlag.Enabled = false;
            }
            else
            {
                timeSendFlag.Enabled = true;
                sendbutton.Text = "开始采集";
                openCom.Enabled = true;
                disflag = false;
                tmr.Stop();
            }

        }
        
        void tmr_Elapsed(object sender, System.Timers.ElapsedEventArgs a)
        {
            //timerDrawI++;
            byte[] sendData = new byte[6];
            sendData[0] = 0x77;
            sendData[1] = (byte)(rand.NextDouble()*25);
            sendData[2] = (byte)(rand.NextDouble()*250);
            sendData[3] = (byte)(rand.NextDouble()*55);
            sendData[4] = (byte)(rand.NextDouble()*250);
            sendData[5] = 0x99;
            comm.Write(sendData, 0,6);
        }
        private void selectPath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog BrowDialog = new System.Windows.Forms.FolderBrowserDialog();
            BrowDialog.ShowNewFolderButton = true;
            BrowDialog.Description = "请选择数据保存位置";
            BrowDialog.ShowDialog();
            if (BrowDialog.SelectedPath != "")
            { 
                filePath.Text= BrowDialog.SelectedPath;
                saveToXml(textBaud.Text, sendTime.Text, filePath.Text, textDatanum.Text);
            }
        }

        private void f_timerDrawStart()
        {
            timerDrawI = 0;
            
        }
        private void getFromXml()
        {
            //获得数据
            if (!File.Exists(cpath))
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(dec);
                // 根节点
                XmlElement root = doc.CreateElement("config");
                doc.AppendChild(root);
                XmlElement body = doc.CreateElement("baud");
                root.AppendChild(body);
                body = doc.CreateElement("time");
                root.AppendChild(body);
                body = doc.CreateElement("path");
                root.AppendChild(body);
                body = doc.CreateElement("datanum");
                root.AppendChild(body);
                doc.Save(cpath);

               
                saveToXml("345600", "10", "c:\\Wave Data", "6000");
                textBaud.Text = "345600";
                sendTime.Text = "10";
                filePath.Text = "c:\\Wave Data";
                textDatanum.Text = "6000";
                // 默认路径新建文件夹
                string path = @"c:\Wave Data";
                try
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                finally { }
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(cpath);
                XmlNode node;
                node = xmlDoc.SelectSingleNode("config/path");
                filePath.Text = node.InnerText;
                node = xmlDoc.SelectSingleNode("config/baud");
                textBaud.Text = node.InnerText;
                node = xmlDoc.SelectSingleNode("config/time");
                sendTime.Text = node.InnerText;
                node = xmlDoc.SelectSingleNode("config/datanum");
                textDatanum.Text = node.InnerText;
            }


        }
        private void saveToXml(string baud, string time, string path, string datanum )
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(cpath);
            XmlNode node;
            node = xmlDoc.SelectSingleNode("config/baud");
            if (node == null)
            {
                XmlElement n = xmlDoc.CreateElement("baud");
                n.InnerText = baud;
                xmlDoc.SelectSingleNode("config").AppendChild(n);
            }
            else
            {
                node.InnerText = baud;
            }
            node = xmlDoc.SelectSingleNode("config/time");
            if (node == null)
            {
                XmlElement n = xmlDoc.CreateElement("time");
                n.InnerText = time;
                xmlDoc.SelectSingleNode("config").AppendChild(n);
            }
            else
            {
                node.InnerText = time;
            }
            node = xmlDoc.SelectSingleNode("config/path");
            if (node == null)
            {
                XmlElement n = xmlDoc.CreateElement("path");
                n.InnerText = path;
                xmlDoc.SelectSingleNode("config").AppendChild(n);
            }
            else
            {
                node.InnerText = path;
            }
            node = xmlDoc.SelectSingleNode("config/datanum");
            if (node == null)
            {
                XmlElement n = xmlDoc.CreateElement("datanum");
                n.InnerText = datanum;
                xmlDoc.SelectSingleNode("config").AppendChild(n);
            }
            else
            {
                node.InnerText = datanum;
            }
            xmlDoc.Save(cpath);

        }

        private void sendTime_TextChanged(object sender, EventArgs e)
        {
            saveToXml(textBaud.Text, sendTime.Text, filePath.Text, textDatanum.Text);
        }

        private void textBaud_TextChanged(object sender, EventArgs e)
        {
            saveToXml(textBaud.Text, sendTime.Text, filePath.Text, textDatanum.Text);
        }

        private void textDatanum_TextChanged(object sender, EventArgs e)
        {
            saveToXml(textBaud.Text, sendTime.Text, filePath.Text, textDatanum.Text);
        }

        private void setChartButton_Click(object sender, EventArgs e)
        {
            zGraphTest.m_SySnameX = xLabel.Text.ToString();
            zGraphTest.m_SySnameY = yLabel.Text.ToString();
            //String aa = xDisDataNum.Text.ToString();
            /*if(aa!=null)
            {
                zGraphTest.m_fXEndSYS = int.Parse(aa);
            }*/
            zGraphTest.Refresh();
        }

        private void sendCmdButton_Click(object sender, EventArgs e)
        {
            string aa = sendText.Text.ToString();
            if (aa != null)
            {
                strToHexByte(aa);
                cmdDataSend = true;
            }

        }

        private void strToHexByte(string hexString)
        {
            //利用正则方式把空格去掉
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            cmdData = new byte[hexString.Length / 2];
            for(int i=0;i<cmdData.Length;i++)
            {
                //取出字符串以16进制进行转换
                cmdData[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }
        }

        private void addDataToChart(byte a,byte b,byte c,byte d)
        {
            timerDrawI++;
            x1.Add(timerDrawI);
            y1.Add(a * 256 + b);
            x2.Add(timerDrawI);
            y2.Add(c * 256 + d);
            if(x1.Count()%30==0)
            {
                reChartUpdate = true;
            }
            if(timerDrawI>6000)
            {
                x1.RemoveAt(0);
                y1.RemoveAt(0);
                x2.RemoveAt(0);
                y2.RemoveAt(0);
            }
        }
        private void addDataToBuffer(byte a,byte b,byte c,byte d)
        {
            if (fifoflag == false)
            {
                fifoA[bytecount * 4] = a;
                fifoA[bytecount * 4 + 1] = b;
                fifoA[bytecount * 4 + 2] = c;
                fifoA[bytecount * 4 + 3] = d;
            }
            else
            {
                fifoB[bytecount * 4] = a;
                fifoB[bytecount * 4 + 1] = b;
                fifoB[bytecount * 4 + 2] = c;
                fifoB[bytecount * 4 + 3] = d;
            }

            if (bytecount < (bytenum - 1))
            {
                bytecount++;
            }
            else
            {
                bytecount = 0;
                if (fifoflag == false)
                {
                    fifoflag = true;
                }
                else
                {
                    fifoflag = false;
                }
                writeflag = true;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread.Abort();
        }

        private void clearChart_Click(object sender, EventArgs e)
        {
            timerDrawI = 0;
            x1.Clear();
            y1.Clear();
            x2.Clear();
            y2.Clear();
            zGraphTest.f_ClearAllPix();
            zGraphTest.f_reXY();
            zGraphTest.f_InitMode(Pengpai.UI.ZGraph.GraphStyle.DefaultMoveMode);
            zGraphTest.f_LoadOnePix(x1, y1, Color.Purple, 2);
            zGraphTest.f_AddPix(x2, y2, Color.Red, 2);
            zGraphTest.Refresh();
        }
    }
}
