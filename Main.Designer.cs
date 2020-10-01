namespace kahootify
{
    partial class Main
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
            this.startAnalysisBtn = new System.Windows.Forms.Button();
            this.stopAnalysisBtn = new System.Windows.Forms.Button();
            this.tlcTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brcTxt = new System.Windows.Forms.TextBox();
            this.currentPosLbl = new System.Windows.Forms.Label();
            this.screenRegionPB = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guessTxt = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.screenRegionPB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startAnalysisBtn
            // 
            this.startAnalysisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startAnalysisBtn.Location = new System.Drawing.Point(874, 15);
            this.startAnalysisBtn.Name = "startAnalysisBtn";
            this.startAnalysisBtn.Size = new System.Drawing.Size(111, 51);
            this.startAnalysisBtn.TabIndex = 0;
            this.startAnalysisBtn.Text = "Start Analysis";
            this.startAnalysisBtn.UseVisualStyleBackColor = true;
            this.startAnalysisBtn.Click += new System.EventHandler(this.startAnalysisBtn_Click);
            // 
            // stopAnalysisBtn
            // 
            this.stopAnalysisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopAnalysisBtn.Location = new System.Drawing.Point(991, 15);
            this.stopAnalysisBtn.Name = "stopAnalysisBtn";
            this.stopAnalysisBtn.Size = new System.Drawing.Size(111, 51);
            this.stopAnalysisBtn.TabIndex = 1;
            this.stopAnalysisBtn.Text = "Stop Analysis";
            this.stopAnalysisBtn.UseVisualStyleBackColor = true;
            this.stopAnalysisBtn.Click += new System.EventHandler(this.stopAnalysisBtn_Click);
            // 
            // tlcTxt
            // 
            this.tlcTxt.Location = new System.Drawing.Point(155, 15);
            this.tlcTxt.Name = "tlcTxt";
            this.tlcTxt.Size = new System.Drawing.Size(100, 22);
            this.tlcTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top Left Corner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bottom Right Corner:";
            // 
            // brcTxt
            // 
            this.brcTxt.Location = new System.Drawing.Point(155, 43);
            this.brcTxt.Name = "brcTxt";
            this.brcTxt.Size = new System.Drawing.Size(100, 22);
            this.brcTxt.TabIndex = 4;
            // 
            // currentPosLbl
            // 
            this.currentPosLbl.AutoSize = true;
            this.currentPosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPosLbl.Location = new System.Drawing.Point(267, 17);
            this.currentPosLbl.Name = "currentPosLbl";
            this.currentPosLbl.Size = new System.Drawing.Size(158, 17);
            this.currentPosLbl.TabIndex = 6;
            this.currentPosLbl.Text = "Current mouse position:";
            // 
            // screenRegionPB
            // 
            this.screenRegionPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenRegionPB.Location = new System.Drawing.Point(3, 18);
            this.screenRegionPB.Name = "screenRegionPB";
            this.screenRegionPB.Size = new System.Drawing.Size(357, 571);
            this.screenRegionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.screenRegionPB.TabIndex = 7;
            this.screenRegionPB.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.screenRegionPB);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 592);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region Preview";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(266, 41);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(183, 20);
            this.statusLbl.TabIndex = 9;
            this.statusLbl.Text = "Current status: OFF.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.browser);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.guessTxt);
            this.groupBox2.Location = new System.Drawing.Point(381, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 592);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // guessTxt
            // 
            this.guessTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guessTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessTxt.Location = new System.Drawing.Point(10, 27);
            this.guessTxt.Name = "guessTxt";
            this.guessTxt.Size = new System.Drawing.Size(580, 34);
            this.guessTxt.TabIndex = 0;
            this.guessTxt.Text = "Current best guess is \"\".";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Enabled = false;
            this.searchBtn.Location = new System.Drawing.Point(596, 21);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(120, 37);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(6, 64);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(710, 522);
            this.browser.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currentPosLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brcTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlcTxt);
            this.Controls.Add(this.stopAnalysisBtn);
            this.Controls.Add(this.startAnalysisBtn);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.screenRegionPB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startAnalysisBtn;
        private System.Windows.Forms.Button stopAnalysisBtn;
        private System.Windows.Forms.TextBox tlcTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brcTxt;
        private System.Windows.Forms.Label currentPosLbl;
        private System.Windows.Forms.PictureBox screenRegionPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label guessTxt;
        private System.Windows.Forms.WebBrowser browser;
    }
}

