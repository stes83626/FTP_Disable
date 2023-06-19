namespace FTP_Disable
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.chkKey = new System.Windows.Forms.CheckBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFTPUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConnectMsg = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.AutoTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(614, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "結束離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.chkAuto);
            this.panel1.Controls.Add(this.textBoxFilePath);
            this.panel1.Controls.Add(this.btnPath);
            this.panel1.Controls.Add(this.chkKey);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxFTPUrl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 429);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(546, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 36);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "儲存設定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 29);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Visible = false;
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(72, 292);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(92, 24);
            this.chkAuto.TabIndex = 23;
            this.chkAuto.Text = "自動更新";
            this.chkAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(184, 235);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(492, 29);
            this.textBoxFilePath.TabIndex = 22;
            this.textBoxFilePath.Visible = false;
            // 
            // btnPath
            // 
            this.btnPath.ForeColor = System.Drawing.Color.Black;
            this.btnPath.Location = new System.Drawing.Point(184, 195);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(96, 34);
            this.btnPath.TabIndex = 21;
            this.btnPath.Text = "選擇路徑";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Visible = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // chkKey
            // 
            this.chkKey.AutoSize = true;
            this.chkKey.Location = new System.Drawing.Point(72, 201);
            this.chkKey.Name = "chkKey";
            this.chkKey.Size = new System.Drawing.Size(92, 24);
            this.chkKey.TabIndex = 20;
            this.chkKey.Text = "需要金錀";
            this.chkKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKey.UseVisualStyleBackColor = true;
            this.chkKey.CheckedChanged += new System.EventHandler(this.chkKey_CheckedChanged);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(184, 138);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(251, 29);
            this.textBoxUser.TabIndex = 19;
            this.textBoxUser.Text = "parchere";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "使用者名稱：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFTPUrl
            // 
            this.textBoxFTPUrl.Location = new System.Drawing.Point(184, 28);
            this.textBoxFTPUrl.Name = "textBoxFTPUrl";
            this.textBoxFTPUrl.Size = new System.Drawing.Size(251, 29);
            this.textBoxFTPUrl.TabIndex = 15;
            this.textBoxFTPUrl.Text = "13.251.79.217";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "連線主機網址：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxConnectMsg
            // 
            this.textBoxConnectMsg.Location = new System.Drawing.Point(32, 472);
            this.textBoxConnectMsg.Multiline = true;
            this.textBoxConnectMsg.Name = "textBoxConnectMsg";
            this.textBoxConnectMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConnectMsg.Size = new System.Drawing.Size(547, 143);
            this.textBoxConnectMsg.TabIndex = 20;
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(614, 472);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 36);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "手動更新";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // AutoTimer
            // 
            this.AutoTimer.Enabled = true;
            this.AutoTimer.Interval = 40000;
            this.AutoTimer.Tick += new System.EventHandler(this.AutoTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(775, 627);
            this.ControlBox = false;
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textBoxConnectMsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.CheckBox chkKey;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFTPUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConnectMsg;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer AutoTimer;
        private System.Windows.Forms.Button button1;
    }
}

