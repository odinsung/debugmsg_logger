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

namespace debugmsg_logger
{
    public partial class Form1 : Form
    {
        SerialPort Port = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            ComPortItemInit();
        }

        #region Com Port
        private void ComPortItemInit()
        {
            cbComPort.Items.Clear();
            foreach(string portName in SerialPort.GetPortNames()) {
                cbComPort.Items.Add(portName);
            }
            if (cbComPort.Items.Count > 0) {
                cbComPort.SelectedIndex = 0;
            }
            cbBaudRate.SelectedIndex = 2; // Default: 19200
            btnCloseComPort.Enabled = false;
            Port.DataReceived += Port_DataReceived;
        }

        private int isprint(int c)
        {
            if (c >= 0x20 && c <= 0x7e) {
                return 1;
            } else {
                return 0;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int data = 0;
            string str = string.Empty;
            while(Port.BytesToRead > 0) {
                data = Port.ReadChar();
                if (data == 0x0d || isprint(data) == 1) { // 0x0d, 0x0a = new line
                    Msg(data);
                }
            }            
        }

        private void btnOpenComPort_Click(object sender, EventArgs e)
        {
            if (cbComPort.Items.Count == 0) {
                Msg("無可用的 Com Port");
                return;
            }else if (Port.IsOpen) {
                Msg("Com Port 已開啟");
                return;
            }
            switch (cbBaudRate.SelectedIndex) {
            case 0: Port.BaudRate = 4800; break;
            case 1: Port.BaudRate = 9600; break;
            case 2: Port.BaudRate = 19200; break;
            case 3: Port.BaudRate = 115200; break;
            default: Msg("Baud Rate Error!"); return;
            }
            try {
                // config comport & open
                Port.Parity = Parity.None;
                Port.DataBits = 8;
                Port.StopBits = StopBits.One;
                Port.DtrEnable = false;
                Port.RtsEnable = false;
                Port.PortName = cbComPort.Text;
                Port.ReceivedBytesThreshold = 1;
                Port.Open();
            } catch (UnauthorizedAccessException ex) {
                Msg("Com Port 開啟失敗! " + ex.Message);
                return;
            }
            Msg("Com Port 已開啟!");
            btnOpenComPort.Enabled = false;
            btnCloseComPort.Enabled = true;
            btnCloseComPort.Select();
        }
        private void btnCloseComPort_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen) {
                Port.Close();
                btnCloseComPort.Enabled = false;
                btnOpenComPort.Enabled = true;
            }
            Msg("Com port 已關閉");
        }

        #endregion

        #region Message
        private void Msg(string msg)
        {
            tbMsg.Invoke(new EventHandler(delegate {
                //tbMsg.Text += Environment.NewLine + DateTime.Now.ToString("MM/dd HH:mm:ss") + " " + msg;
                tbMsg.Text += Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + "   " + msg;
                labelMsgLen.Text = tbMsg.Text.Length.ToString();
            }));
        }
        private void Msg(int ch)
        {
            tbMsg.Invoke(new EventHandler(delegate {
                if (ch == 0x0d) {
                    //tbMsg.Text += Environment.NewLine + DateTime.Now.ToString("MM/dd HH:mm:ss") + " ";
                    tbMsg.Text += Environment.NewLine + DateTime.Now.ToString("HH:mm:ss") + "   ";
                } else if (isprint(ch) == 1) {
                    tbMsg.Text += ((char)ch).ToString();
                }
                labelMsgLen.Text = tbMsg.Text.Length.ToString();
            }));
        }
        private void textBox_KeepCursorLast(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectionStart = tb.TextLength;
            tb.ScrollToCaret();
        }
        private void btnClrMsg_Click(object sender, EventArgs e)
        {
            tbMsg.Clear();
        }
        private void btnFakeMsg_Click(object sender, EventArgs e)
        {
            Msg("Fake message.");
        }
        private void btnFakeComPortData_Click(object sender, EventArgs e)
        {
            int[] buf = new int[10];
            buf[0] = 0x0d;
            buf[1] = 0x0a;
            buf[2] = 0x31;
            buf[3] = 0x32;
            buf[4] = 0x33;
            buf[5] = 0x34;
            buf[6] = 0x35;
            buf[7] = 0x36;
            buf[8] = 0x37;
            buf[9] = 0x38;
            foreach(int ch in buf) {
                Msg(ch);
            }
        }
        #endregion

        #region File
        private bool QuickSave(string str)
        {
            bool isOk = false;
            int errorFound = -1;
            string errKeyWord = tbErrKeyWord.Text;
            errorFound = str.IndexOf(errKeyWord, 0);
            string filename = FileNameGen(errorFound == -1? false : true); // -1 means 'not found'
            try {
                StreamWriter sw = new StreamWriter(filename, false);
                sw.WriteLine(str);
                sw.Close();
                isOk = true;
                labelAutoSave.Text = filename + " saved.";
            } catch (IOException ex) {
                Msg(ex.Message);
            }
            return isOk;
        }
        private string FileNameGen(bool errorFound)
        {
            string fileName = "MsgLog";
            DateTime now = DateTime.Now;
            fileName += now.Year.ToString("0000") + now.Month.ToString("00") + now.Day.ToString("00") + 
                        now.Hour.ToString("00") + now.Minute.ToString("00") + now.Second.ToString("00") + 
                        (errorFound? "_Err" : "") +
                        ".txt";
            return fileName;
        }
        private void btnQuickSave_Click(object sender, EventArgs e)
        {
            if (QuickSave(tbMsg.Text)) {
                tbMsg.Clear();
            } else {
                Msg("存檔失敗");
            }
        }
        private void timerAutoSave_Tick(object sender, EventArgs e)
        {
            int autoSaveCharCount = 60000; // default value
            try {
                autoSaveCharCount = Convert.ToInt32(tbAutoSaveCharCnt.Text);
            }catch(Exception ex) {
                Msg(ex.Message);
            }
            if (tbMsg.Text.Length > autoSaveCharCount) {
                if (QuickSave(tbMsg.Text)) {
                    tbMsg.Clear();
                } else {
                    Msg("存檔失敗");
                }
            }
        }

        #endregion

        private void tbAutoSaveCharCnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
