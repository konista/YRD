namespace YRD
{
    partial class YRD
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
            this.BTN_Start = new System.Windows.Forms.Button();
            this.CB_OpenWhenFound = new System.Windows.Forms.CheckBox();
            this.CB_WeChat = new System.Windows.Forms.CheckBox();
            this.CB_Month = new System.Windows.Forms.ComboBox();
            this.CB_Complete = new System.Windows.Forms.ComboBox();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(322, 155);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(75, 23);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "开始查询";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // CB_OpenWhenFound
            // 
            this.CB_OpenWhenFound.AutoSize = true;
            this.CB_OpenWhenFound.Location = new System.Drawing.Point(12, 193);
            this.CB_OpenWhenFound.Name = "CB_OpenWhenFound";
            this.CB_OpenWhenFound.Size = new System.Drawing.Size(132, 16);
            this.CB_OpenWhenFound.TabIndex = 1;
            this.CB_OpenWhenFound.Text = "找到后自动打开网页";
            this.CB_OpenWhenFound.UseVisualStyleBackColor = true;
            // 
            // CB_WeChat
            // 
            this.CB_WeChat.AutoSize = true;
            this.CB_WeChat.Location = new System.Drawing.Point(12, 215);
            this.CB_WeChat.Name = "CB_WeChat";
            this.CB_WeChat.Size = new System.Drawing.Size(108, 16);
            this.CB_WeChat.TabIndex = 2;
            this.CB_WeChat.Text = "找到后微信通知";
            this.CB_WeChat.UseVisualStyleBackColor = true;
            // 
            // CB_Month
            // 
            this.CB_Month.FormattingEnabled = true;
            this.CB_Month.Items.AddRange(new object[] {
            "12",
            "18",
            "24",
            "36",
            "48",
            "ALL"});
            this.CB_Month.Location = new System.Drawing.Point(36, 28);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(72, 20);
            this.CB_Month.TabIndex = 3;
            // 
            // CB_Complete
            // 
            this.CB_Complete.FormattingEnabled = true;
            this.CB_Complete.Items.AddRange(new object[] {
            "0,50",
            "50,80",
            "80,99",
            "99,100"});
            this.CB_Complete.Location = new System.Drawing.Point(142, 28);
            this.CB_Complete.Name = "CB_Complete";
            this.CB_Complete.Size = new System.Drawing.Size(72, 20);
            this.CB_Complete.TabIndex = 4;
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(322, 189);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(75, 23);
            this.BTN_Stop.TabIndex = 5;
            this.BTN_Stop.Text = "停止";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // YRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 284);
            this.Controls.Add(this.BTN_Stop);
            this.Controls.Add(this.CB_Complete);
            this.Controls.Add(this.CB_Month);
            this.Controls.Add(this.CB_WeChat);
            this.Controls.Add(this.CB_OpenWhenFound);
            this.Controls.Add(this.BTN_Start);
            this.Name = "YRD";
            this.Text = "YRD";
            this.Load += new System.EventHandler(this.YRD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.CheckBox CB_OpenWhenFound;
        private System.Windows.Forms.CheckBox CB_WeChat;
        private System.Windows.Forms.ComboBox CB_Month;
        private System.Windows.Forms.ComboBox CB_Complete;
        private System.Windows.Forms.Button BTN_Stop;
    }
}

