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
            this.tbAutoSaveCharCnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbErrKeyWord = new System.Windows.Forms.TextBox();
            this.checkBoxTimeStamp = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFakeMsg = new System.Windows.Forms.TextBox();
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
            this.tbMsg.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMsg.Location = new System.Drawing.Point(12, 58);
            this.tbMsg.MaxLength = 131072;
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ReadOnly = true;
            this.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMsg.Size = new System.Drawing.Size(1314, 735);
            this.tbMsg.TabIndex = 5;
            this.tbMsg.TextChanged += new System.EventHandler(this.textBox_KeepCursorLast);
            // 
            // btnClrMsg
            // 
            this.btnClrMsg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClrMsg.Location = new System.Drawing.Point(686, 11);
            this.btnClrMsg.Name = "btnClrMsg";
            this.btnClrMsg.Size = new System.Drawing.Size(221, 41);
            this.btnClrMsg.TabIndex = 6;
            this.btnClrMsg.Text = "清空訊息窗而不儲存";
            this.btnClrMsg.UseVisualStyleBackColor = true;
            this.btnClrMsg.Click += new System.EventHandler(this.btnClrMsg_Click);
            // 
            // btnFakeMsg
            // 
            this.btnFakeMsg.Location = new System.Drawing.Point(1340, 144);
            this.btnFakeMsg.Name = "btnFakeMsg";
            this.btnFakeMsg.Size = new System.Drawing.Size(244, 32);
            this.btnFakeMsg.TabIndex = 7;
            this.btnFakeMsg.Text = "Fake Msg";
            this.btnFakeMsg.UseVisualStyleBackColor = true;
            this.btnFakeMsg.Click += new System.EventHandler(this.btnFakeMsg_Click);
            // 
            // btnQuickSave
            // 
            this.btnQuickSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuickSave.Location = new System.Drawing.Point(440, 12);
            this.btnQuickSave.Name = "btnQuickSave";
            this.btnQuickSave.Size = new System.Drawing.Size(240, 40);
            this.btnQuickSave.TabIndex = 8;
            this.btnQuickSave.Text = "儲存訊息後清空訊息窗";
            this.btnQuickSave.UseVisualStyleBackColor = true;
            this.btnQuickSave.Click += new System.EventHandler(this.btnQuickSave_Click);
            // 
            // btnFakeComPortData
            // 
            this.btnFakeComPortData.Location = new System.Drawing.Point(1340, 182);
            this.btnFakeComPortData.Name = "btnFakeComPortData";
            this.btnFakeComPortData.Size = new System.Drawing.Size(244, 32);
            this.btnFakeComPortData.TabIndex = 9;
            this.btnFakeComPortData.Text = "Fake Com Port Data";
            this.btnFakeComPortData.UseVisualStyleBackColor = true;
            this.btnFakeComPortData.Visible = false;
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
            this.labelMsgLen.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgLen.Location = new System.Drawing.Point(1338, 700);
            this.labelMsgLen.Name = "labelMsgLen";
            this.labelMsgLen.Size = new System.Drawing.Size(18, 19);
            this.labelMsgLen.TabIndex = 10;
            this.labelMsgLen.Text = "0";
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Location = new System.Drawing.Point(1338, 671);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(53, 12);
            this.labelAutoSave.TabIndex = 11;
            this.labelAutoSave.Text = "字元計數";
            // 
            // tbAutoSaveCharCnt
            // 
            this.tbAutoSaveCharCnt.Location = new System.Drawing.Point(1433, 227);
            this.tbAutoSaveCharCnt.Name = "tbAutoSaveCharCnt";
            this.tbAutoSaveCharCnt.Size = new System.Drawing.Size(151, 22);
            this.tbAutoSaveCharCnt.TabIndex = 12;
            this.tbAutoSaveCharCnt.Text = "65536";
            this.tbAutoSaveCharCnt.TextChanged += new System.EventHandler(this.tbAutoSaveCharCnt_TextChanged);
            this.tbAutoSaveCharCnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAutoSaveCharCnt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1338, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "自動儲存字元數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1338, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "錯誤關鍵字";
            // 
            // tbErrKeyWord
            // 
            this.tbErrKeyWord.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbErrKeyWord.Location = new System.Drawing.Point(1433, 255);
            this.tbErrKeyWord.Name = "tbErrKeyWord";
            this.tbErrKeyWord.Size = new System.Drawing.Size(151, 22);
            this.tbErrKeyWord.TabIndex = 15;
            this.tbErrKeyWord.Text = "NUC980 IBR 201";
            // 
            // checkBoxTimeStamp
            // 
            this.checkBoxTimeStamp.AutoSize = true;
            this.checkBoxTimeStamp.Location = new System.Drawing.Point(1340, 352);
            this.checkBoxTimeStamp.Name = "checkBoxTimeStamp";
            this.checkBoxTimeStamp.Size = new System.Drawing.Size(156, 16);
            this.checkBoxTimeStamp.TabIndex = 16;
            this.checkBoxTimeStamp.Text = "每行訊息前加上時間戳記";
            this.checkBoxTimeStamp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(1338, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 46);
            this.label4.TabIndex = 17;
            this.label4.Text = "儲存內容有出現關鍵字的話，會在檔名後面加註Err";
            // 
            // textBoxFakeMsg
            // 
            this.textBoxFakeMsg.Location = new System.Drawing.Point(1340, 38);
            this.textBoxFakeMsg.Multiline = true;
            this.textBoxFakeMsg.Name = "textBoxFakeMsg";
            this.textBoxFakeMsg.Size = new System.Drawing.Size(244, 100);
            this.textBoxFakeMsg.TabIndex = 18;
            this.textBoxFakeMsg.Text = "This is a fake message.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 805);
            this.Controls.Add(this.textBoxFakeMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxTimeStamp);
            this.Controls.Add(this.tbErrKeyWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAutoSaveCharCnt);
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
            this.Text = "Debug Message Logger - V1.01";
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
        private System.Windows.Forms.TextBox tbAutoSaveCharCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbErrKeyWord;
        private System.Windows.Forms.CheckBox checkBoxTimeStamp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFakeMsg;
    }
}

