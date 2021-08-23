
namespace NanoFaucet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.TXT_wallet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Logs = new System.Windows.Forms.TextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_Time = new System.Windows.Forms.Label();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(401, 27);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(89, 31);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "START";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // TXT_wallet
            // 
            this.TXT_wallet.Location = new System.Drawing.Point(12, 33);
            this.TXT_wallet.Name = "TXT_wallet";
            this.TXT_wallet.Size = new System.Drawing.Size(383, 20);
            this.TXT_wallet.TabIndex = 1;
            this.TXT_wallet.Text = "nano_1attz8uksuo86396watngxaxsodzbwtn8563ebma8sc16aefrxqd5zp7jbcw";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "wallet address";
            // 
            // TXT_Logs
            // 
            this.TXT_Logs.Location = new System.Drawing.Point(12, 100);
            this.TXT_Logs.Multiline = true;
            this.TXT_Logs.Name = "TXT_Logs";
            this.TXT_Logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_Logs.Size = new System.Drawing.Size(478, 101);
            this.TXT_Logs.TabIndex = 3;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LBL_Time
            // 
            this.LBL_Time.AutoSize = true;
            this.LBL_Time.Location = new System.Drawing.Point(12, 70);
            this.LBL_Time.Name = "LBL_Time";
            this.LBL_Time.Size = new System.Drawing.Size(30, 13);
            this.LBL_Time.TabIndex = 4;
            this.LBL_Time.Text = "Time";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(273, 70);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(122, 13);
            this.LinkLabel1.TabIndex = 5;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "https://tranquocdai.com";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 224);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.LBL_Time);
            this.Controls.Add(this.TXT_Logs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_wallet);
            this.Controls.Add(this.BTN_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Free Nano Faucet v1.0 - tranquocdai.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.TextBox TXT_wallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Logs;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label LBL_Time;
        private System.Windows.Forms.LinkLabel LinkLabel1;
    }
}

