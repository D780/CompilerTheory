namespace Lexical_Analysis
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtBoxSource = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(13, 13);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(133, 33);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择源文件";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtBoxSource
            // 
            this.txtBoxSource.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxSource.Location = new System.Drawing.Point(13, 54);
            this.txtBoxSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSource.Multiline = true;
            this.txtBoxSource.Name = "txtBoxSource";
            this.txtBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxSource.Size = new System.Drawing.Size(375, 451);
            this.txtBoxSource.TabIndex = 1;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(400, 274);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(56, 33);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "扫描";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(712, 13);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(133, 33);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxResult.Location = new System.Drawing.Point(464, 54);
            this.txtBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxResult.Size = new System.Drawing.Size(381, 451);
            this.txtBoxResult.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 518);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBoxSource);
            this.Controls.Add(this.btnSelect);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(874, 557);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(874, 557);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "词法分析程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtBoxSource;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TextBox txtBoxResult;
    }
}

