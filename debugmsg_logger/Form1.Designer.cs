namespace debugmsg_logger
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenComPort = new System.Windows.Forms.Button();
            this.btnCloseComPort = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btnClrMsg = new System.Windows.Forms.Button();
            this.btnFakeMsg = new System.Windows.Forms.Button();
            this.btnQuickSave = new System.Windows.Forms.Button();
            this.btnFakeComPortData = new System.Windows.Forms.Button();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.labelMsgLen = new System.Windows.Forms.Label();
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(12, 12);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(90, 20);
            this.cbComPort.TabIndex = 0;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(165, 11);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(116, 20);
            this.cbBaudRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "BaudRate";
            // 
            // btnOpenComPort
            // 
            this.btnOpenComPort.Location = new System.Drawing.Point(287, 12);
            this.btnOpenComPort.Name = "btnOpenComPort";
            this.btnOpenComPort.Size = new System.Drawing.Size(71, 20);
            this.btnOpenComPort.TabIndex = 3;
            this.btnOpenComPort.Text = "Open";
            this.btnOpenComPort.UseVisualStyleBackColor = true;
            this.btnOpenComPort.Click += new System.EventHandler(this.btnOpenComPort_Click);
            // 
            // btnCloseComPort
            // 
            this.btnCloseComPort.Location = new System.Drawing.Point(364, 12);
            this.btnCloseComPort.Name = "btnCloseComPort";
            this.btnCloseComPort.Size = new System.Drawing.Size(70, 20);
            this.btnCloseComPort.TabIndex = 4;
            this.btnCloseComPort.Text = "Close";
            this.btnCloseComPort.UseVisualStyleBackColor = true;
            this.btnCloseComPort.Click += new System.EventHandler(this.btnCloseComPort_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.BackColor = System.Drawing.Color.White;
            this.tbMsg.Location = new System.Drawing.Point(12, 38);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ReadOnly = true;
            this.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMsg.Size = new System.Drawing.Size(746, 575);
            this.tbMsg.TabIndex = 5;
            this.tbMsg.TextChanged += new System.EventHandler(this.textBox_KeepCursorLast);
            // 
            // btnClrMsg
            // 
            this.btnClrMsg.Location = new System.Drawing.Point(677, 15);
            this.btnClrMsg.Name = "btnClrMsg";
            this.btnClrMsg.Size = new System.Drawing.Size(81, 20);
            this.btnClrMsg.TabIndex = 6;
            this.btnClrMsg.Text = "Clear Msg";
            this.btnClrMsg.UseVisualStyleBackColor = true;
            this.btnClrMsg.Click += new System.EventHandler(this.btnClrMsg_Click);
            // 
            // btnFakeMsg
            // 
            this.btnFakeMsg.Location = new System.Drawing.Point(766, 38);
            this.btnFakeMsg.Name = "btnFakeMsg";
            this.btnFakeMsg.Size = new System.Drawing.Size(125, 20);
            this.btnFakeMsg.TabIndex = 7;
            this.btnFakeMsg.Text = "Fake Msg";
            this.btnFakeMsg.UseVisualStyleBackColor = true;
            this.btnFakeMsg.Click += new System.EventHandler(this.btnFakeMsg_Click);
            // 
            // btnQuickSave
            // 
            this.btnQuickSave.Location = new System.Drawing.Point(440, 12);
            this.btnQuickSave.Name = "btnQuickSave";
            this.btnQuickSave.Size = new System.Drawing.Size(84, 20);
            this.btnQuickSave.TabIndex = 8;
            this.btnQuickSave.Text = "Manual Save";
            this.btnQuickSave.UseVisualStyleBackColor = true;
            this.btnQuickSave.Click += new System.EventHandler(this.btnQuickSave_Click);
            // 
            // btnFakeComPortData
            // 
            this.btnFakeComPortData.Location = new System.Drawing.Point(766, 64);
            this.btnFakeComPortData.Name = "btnFakeComPortData";
            this.btnFakeComPortData.Size = new System.Drawing.Size(125, 20);
            this.btnFakeComPortData.TabIndex = 9;
            this.btnFakeComPortData.Text = "Fake Com Port Data";
            this.btnFakeComPortData.UseVisualStyleBackColor = true;
            this.btnFakeComPortData.Click += new System.EventHandler(this.btnFakeComPortData_Click);
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Enabled = true;
            this.timerAutoSave.Interval = 5000;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // labelMsgLen
            // 
            this.labelMsgLen.AutoSize = true;
            this.labelMsgLen.Location = new System.Drawing.Point(764, 519);
            this.labelMsgLen.Name = "labelMsgLen";
            this.labelMsgLen.Size = new System.Drawing.Size(11, 12);
            this.labelMsgLen.TabIndex = 10;
            this.labelMsgLen.Text = "0";
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Location = new System.Drawing.Point(764, 490);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(49, 12);
            this.labelAutoSave.TabIndex = 11;
            this.labelAutoSave.Text = "auto-save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 625);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.labelMsgLen);
            this.Controls.Add(this.btnFakeComPortData);
            this.Controls.Add(this.btnQuickSave);
            this.Controls.Add(this.btnFakeMsg);
            this.Controls.Add(this.btnClrMsg);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.btnCloseComPort);
            this.Controls.Add(this.btnOpenComPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.cbComPort);
            this.Name = "Form1";
            this.Text = "Debug Message Logger - V1.00";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenComPort;
        private System.Windows.Forms.Button btnCloseComPort;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btnClrMsg;
        private System.Windows.Forms.Button btnFakeMsg;
        private System.Windows.Forms.Button btnQuickSave;
        private System.Windows.Forms.Button btnFakeComPortData;
        private System.Windows.Forms.Timer timerAutoSave;
        private System.Windows.Forms.Label labelMsgLen;
        private System.Windows.Forms.Label labelAutoSave;
    }
}

