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
            this.TB_QueryRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_SendRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_ShowDialog = new System.Windows.Forms.CheckBox();
            this.LB_Number = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BTN_AddReciver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(28, 197);
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
            this.CB_OpenWhenFound.Location = new System.Drawing.Point(12, 59);
            this.CB_OpenWhenFound.Name = "CB_OpenWhenFound";
            this.CB_OpenWhenFound.Size = new System.Drawing.Size(132, 16);
            this.CB_OpenWhenFound.TabIndex = 1;
            this.CB_OpenWhenFound.Text = "找到后自动打开网页";
            this.CB_OpenWhenFound.UseVisualStyleBackColor = true;
            // 
            // CB_WeChat
            // 
            this.CB_WeChat.AutoSize = true;
            this.CB_WeChat.Location = new System.Drawing.Point(12, 81);
            this.CB_WeChat.Name = "CB_WeChat";
            this.CB_WeChat.Size = new System.Drawing.Size(108, 16);
            this.CB_WeChat.TabIndex = 2;
            this.CB_WeChat.Text = "找到后邮件通知";
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
            this.CB_Month.Location = new System.Drawing.Point(77, 6);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(72, 20);
            this.CB_Month.TabIndex = 3;
            // 
            // CB_Complete
            // 
            this.CB_Complete.FormattingEnabled = true;
            this.CB_Complete.Items.AddRange(new object[] {
            "",
            "0,50",
            "50,80",
            "80,99",
            "99,100"});
            this.CB_Complete.Location = new System.Drawing.Point(208, 6);
            this.CB_Complete.Name = "CB_Complete";
            this.CB_Complete.Size = new System.Drawing.Size(72, 20);
            this.CB_Complete.TabIndex = 4;
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(183, 197);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(79, 23);
            this.BTN_Stop.TabIndex = 5;
            this.BTN_Stop.Text = "停止";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // TB_QueryRate
            // 
            this.TB_QueryRate.Location = new System.Drawing.Point(77, 32);
            this.TB_QueryRate.Name = "TB_QueryRate";
            this.TB_QueryRate.Size = new System.Drawing.Size(43, 21);
            this.TB_QueryRate.TabIndex = 6;
            this.TB_QueryRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_QueryRate_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "查询频率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "发送频率";
            // 
            // TB_SendRate
            // 
            this.TB_SendRate.Location = new System.Drawing.Point(208, 32);
            this.TB_SendRate.Name = "TB_SendRate";
            this.TB_SendRate.Size = new System.Drawing.Size(44, 21);
            this.TB_SendRate.TabIndex = 9;
            this.TB_SendRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_SendRate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "时长(月):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "完成度:";
            // 
            // CB_ShowDialog
            // 
            this.CB_ShowDialog.AutoSize = true;
            this.CB_ShowDialog.Location = new System.Drawing.Point(157, 81);
            this.CB_ShowDialog.Name = "CB_ShowDialog";
            this.CB_ShowDialog.Size = new System.Drawing.Size(120, 16);
            this.CB_ShowDialog.TabIndex = 12;
            this.CB_ShowDialog.Text = "找到后弹出提示框";
            this.CB_ShowDialog.UseVisualStyleBackColor = true;
            // 
            // LB_Number
            // 
            this.LB_Number.FormattingEnabled = true;
            this.LB_Number.ItemHeight = 12;
            this.LB_Number.Items.AddRange(new object[] {
            "konista@163.com"});
            this.LB_Number.Location = new System.Drawing.Point(12, 103);
            this.LB_Number.Name = "LB_Number";
            this.LB_Number.Size = new System.Drawing.Size(126, 88);
            this.LB_Number.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(149, 179);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 12);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "去看项目列表";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BTN_AddReciver
            // 
            this.BTN_AddReciver.Location = new System.Drawing.Point(151, 103);
            this.BTN_AddReciver.Name = "BTN_AddReciver";
            this.BTN_AddReciver.Size = new System.Drawing.Size(75, 23);
            this.BTN_AddReciver.TabIndex = 16;
            this.BTN_AddReciver.Text = "添加收件人";
            this.BTN_AddReciver.UseVisualStyleBackColor = true;
            this.BTN_AddReciver.Click += new System.EventHandler(this.BTN_AddReciver_Click);
            // 
            // YRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 232);
            this.Controls.Add(this.BTN_AddReciver);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LB_Number);
            this.Controls.Add(this.CB_ShowDialog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_SendRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_QueryRate);
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
        private System.Windows.Forms.TextBox TB_QueryRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_SendRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CB_ShowDialog;
        private System.Windows.Forms.ListBox LB_Number;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BTN_AddReciver;
    }
}

