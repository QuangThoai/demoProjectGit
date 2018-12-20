namespace Gametrucxanh
{
    partial class Frm_Gametrucxanh
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
            this.txt_sohinh = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.gbox_trucxanh = new System.Windows.Forms.GroupBox();
            this.gbcontrol = new System.Windows.Forms.GroupBox();
            this.gbtt = new System.Windows.Forms.GroupBox();
            this.txt_design = new System.Windows.Forms.RichTextBox();
            this.gbdark = new System.Windows.Forms.GroupBox();
            this.tgian = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.gbcontrol.SuspendLayout();
            this.gbtt.SuspendLayout();
            this.gbdark.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sohinh
            // 
            this.txt_sohinh.Location = new System.Drawing.Point(67, 21);
            this.txt_sohinh.Name = "txt_sohinh";
            this.txt_sohinh.Size = new System.Drawing.Size(100, 20);
            this.txt_sohinh.TabIndex = 0;
            this.txt_sohinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sohinh_KeyPress);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(22, 48);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Bắt đầu";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // gbox_trucxanh
            // 
            this.gbox_trucxanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_trucxanh.Location = new System.Drawing.Point(26, 106);
            this.gbox_trucxanh.Name = "gbox_trucxanh";
            this.gbox_trucxanh.Size = new System.Drawing.Size(983, 266);
            this.gbox_trucxanh.TabIndex = 2;
            this.gbox_trucxanh.TabStop = false;
            this.gbox_trucxanh.Text = "Trúc xanh";
            // 
            // gbcontrol
            // 
            this.gbcontrol.Controls.Add(this.btn_restart);
            this.gbcontrol.Controls.Add(this.txt_sohinh);
            this.gbcontrol.Controls.Add(this.btn_start);
            this.gbcontrol.Location = new System.Drawing.Point(12, 12);
            this.gbcontrol.Name = "gbcontrol";
            this.gbcontrol.Size = new System.Drawing.Size(232, 82);
            this.gbcontrol.TabIndex = 3;
            this.gbcontrol.TabStop = false;
            this.gbcontrol.Text = "Controls Game";
            // 
            // gbtt
            // 
            this.gbtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtt.Controls.Add(this.txt_design);
            this.gbtt.Location = new System.Drawing.Point(810, 2);
            this.gbtt.Name = "gbtt";
            this.gbtt.Size = new System.Drawing.Size(200, 110);
            this.gbtt.TabIndex = 4;
            this.gbtt.TabStop = false;
            this.gbtt.Text = "Thông tin";
            // 
            // txt_design
            // 
            this.txt_design.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_design.Location = new System.Drawing.Point(6, 19);
            this.txt_design.Name = "txt_design";
            this.txt_design.Size = new System.Drawing.Size(188, 81);
            this.txt_design.TabIndex = 0;
            this.txt_design.Text = "";
            // 
            // gbdark
            // 
            this.gbdark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbdark.Controls.Add(this.tgian);
            this.gbdark.Location = new System.Drawing.Point(250, 12);
            this.gbdark.Name = "gbdark";
            this.gbdark.Size = new System.Drawing.Size(560, 100);
            this.gbdark.TabIndex = 5;
            this.gbdark.TabStop = false;
            this.gbdark.Text = "DARKMOON";
            // 
            // tgian
            // 
            this.tgian.AutoSize = true;
            this.tgian.Location = new System.Drawing.Point(62, 39);
            this.tgian.Name = "tgian";
            this.tgian.Size = new System.Drawing.Size(49, 13);
            this.tgian.TabIndex = 0;
            this.tgian.Text = "0000000";
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(133, 47);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 23);
            this.btn_restart.TabIndex = 2;
            this.btn_restart.Text = "Chơi lại";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 385);
            this.Controls.Add(this.gbdark);
            this.Controls.Add(this.gbtt);
            this.Controls.Add(this.gbcontrol);
            this.Controls.Add(this.gbox_trucxanh);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbcontrol.ResumeLayout(false);
            this.gbcontrol.PerformLayout();
            this.gbtt.ResumeLayout(false);
            this.gbdark.ResumeLayout(false);
            this.gbdark.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sohinh;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox gbox_trucxanh;
        private System.Windows.Forms.GroupBox gbcontrol;
        private System.Windows.Forms.GroupBox gbtt;
        private System.Windows.Forms.RichTextBox txt_design;
        private System.Windows.Forms.GroupBox gbdark;
        private System.Windows.Forms.Label tgian;
        private System.Windows.Forms.Button btn_restart;
    }
}

