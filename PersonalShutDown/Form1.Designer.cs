namespace PersonalShutDown
{
    partial class MainForm
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
            this.btnNormalStD = new System.Windows.Forms.Button();
            this.btnSlideToStD = new System.Windows.Forms.Button();
            this.btnTimerStD = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LinkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnNormalStD
            // 
            this.btnNormalStD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNormalStD.Location = new System.Drawing.Point(179, 73);
            this.btnNormalStD.Name = "btnNormalStD";
            this.btnNormalStD.Size = new System.Drawing.Size(198, 40);
            this.btnNormalStD.TabIndex = 0;
            this.btnNormalStD.Text = "普通关机";
            this.btnNormalStD.UseVisualStyleBackColor = true;
            this.btnNormalStD.Click += new System.EventHandler(this.btnNormalStD_Click);
            // 
            // btnSlideToStD
            // 
            this.btnSlideToStD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSlideToStD.Location = new System.Drawing.Point(179, 171);
            this.btnSlideToStD.Name = "btnSlideToStD";
            this.btnSlideToStD.Size = new System.Drawing.Size(198, 40);
            this.btnSlideToStD.TabIndex = 2;
            this.btnSlideToStD.Text = "滑动关机(win10)";
            this.btnSlideToStD.UseVisualStyleBackColor = true;
            this.btnSlideToStD.Click += new System.EventHandler(this.btnSlideToStD_Click);
            // 
            // btnTimerStD
            // 
            this.btnTimerStD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTimerStD.Location = new System.Drawing.Point(179, 279);
            this.btnTimerStD.Name = "btnTimerStD";
            this.btnTimerStD.Size = new System.Drawing.Size(198, 40);
            this.btnTimerStD.TabIndex = 3;
            this.btnTimerStD.Text = "启动定时关机";
            this.btnTimerStD.UseVisualStyleBackColor = true;
            this.btnTimerStD.Click += new System.EventHandler(this.btnTimerStD_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(179, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LinkLabelAbout
            // 
            this.LinkLabelAbout.AutoSize = true;
            this.LinkLabelAbout.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LinkLabelAbout.Location = new System.Drawing.Point(499, 515);
            this.LinkLabelAbout.Name = "LinkLabelAbout";
            this.LinkLabelAbout.Size = new System.Drawing.Size(47, 19);
            this.LinkLabelAbout.TabIndex = 5;
            this.LinkLabelAbout.TabStop = true;
            this.LinkLabelAbout.Text = "关于";
            this.LinkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAbout_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.LinkLabelAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTimerStD);
            this.Controls.Add(this.btnSlideToStD);
            this.Controls.Add(this.btnNormalStD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNormalStD;
        private System.Windows.Forms.Button btnSlideToStD;
        private System.Windows.Forms.Button btnTimerStD;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel LinkLabelAbout;
    }
}

