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
            this.currentPosLbl = new System.Windows.Forms.Label();
            this.screenRegionPB = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.searchBtn = new System.Windows.Forms.Button();
            this.guessTxt = new System.Windows.Forms.Label();
            this.regionSelectBtn = new System.Windows.Forms.Button();
            this.regionSelectPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.screenRegionPB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionSelectPB)).BeginInit();
            this.SuspendLayout();
            // 
            // startAnalysisBtn
            // 
            this.startAnalysisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startAnalysisBtn.Location = new System.Drawing.Point(15, 530);
            this.startAnalysisBtn.Name = "startAnalysisBtn";
            this.startAnalysisBtn.Size = new System.Drawing.Size(110, 43);
            this.startAnalysisBtn.TabIndex = 0;
            this.startAnalysisBtn.Text = "Start Analysis";
            this.startAnalysisBtn.UseVisualStyleBackColor = true;
            this.startAnalysisBtn.Click += new System.EventHandler(this.startAnalysisBtn_Click);
            // 
            // stopAnalysisBtn
            // 
            this.stopAnalysisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopAnalysisBtn.Location = new System.Drawing.Point(131, 530);
            this.stopAnalysisBtn.Name = "stopAnalysisBtn";
            this.stopAnalysisBtn.Size = new System.Drawing.Size(120, 43);
            this.stopAnalysisBtn.TabIndex = 1;
            this.stopAnalysisBtn.Text = "Stop Analysis";
            this.stopAnalysisBtn.UseVisualStyleBackColor = true;
            this.stopAnalysisBtn.Click += new System.EventHandler(this.stopAnalysisBtn_Click);
            // 
            // currentPosLbl
            // 
            this.currentPosLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentPosLbl.AutoSize = true;
            this.currentPosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPosLbl.Location = new System.Drawing.Point(13, 601);
            this.currentPosLbl.Name = "currentPosLbl";
            this.currentPosLbl.Size = new System.Drawing.Size(158, 17);
            this.currentPosLbl.TabIndex = 6;
            this.currentPosLbl.Text = "Current mouse position:";
            this.currentPosLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // screenRegionPB
            // 
            this.screenRegionPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenRegionPB.Location = new System.Drawing.Point(3, 18);
            this.screenRegionPB.Name = "screenRegionPB";
            this.screenRegionPB.Size = new System.Drawing.Size(357, 491);
            this.screenRegionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.screenRegionPB.TabIndex = 7;
            this.screenRegionPB.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.screenRegionPB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 512);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region Preview";
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(12, 581);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(183, 20);
            this.statusLbl.TabIndex = 9;
            this.statusLbl.Text = "Current status: OFF.";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.browser);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.guessTxt);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 610);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(6, 63);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(710, 541);
            this.browser.TabIndex = 2;
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
            // regionSelectBtn
            // 
            this.regionSelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.regionSelectBtn.Location = new System.Drawing.Point(257, 530);
            this.regionSelectBtn.Name = "regionSelectBtn";
            this.regionSelectBtn.Size = new System.Drawing.Size(118, 43);
            this.regionSelectBtn.TabIndex = 11;
            this.regionSelectBtn.Text = "Select Region";
            this.regionSelectBtn.UseVisualStyleBackColor = true;
            this.regionSelectBtn.Click += new System.EventHandler(this.regionSelectBtn_Click);
            // 
            // regionSelectPB
            // 
            this.regionSelectPB.Location = new System.Drawing.Point(0, 0);
            this.regionSelectPB.Margin = new System.Windows.Forms.Padding(0);
            this.regionSelectPB.Name = "regionSelectPB";
            this.regionSelectPB.Size = new System.Drawing.Size(50, 50);
            this.regionSelectPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regionSelectPB.TabIndex = 12;
            this.regionSelectPB.TabStop = false;
            this.regionSelectPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.regionSelect_MouseDown);
            this.regionSelectPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.regionSelect_MouseMove);
            this.regionSelectPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.regionSelect_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 635);
            this.Controls.Add(this.regionSelectPB);
            this.Controls.Add(this.regionSelectBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currentPosLbl);
            this.Controls.Add(this.stopAnalysisBtn);
            this.Controls.Add(this.startAnalysisBtn);
            this.Name = "Main";
            this.Text = "Kahootify - Search and Destroy";
            ((System.ComponentModel.ISupportInitialize)(this.screenRegionPB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.regionSelectPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startAnalysisBtn;
        private System.Windows.Forms.Button stopAnalysisBtn;
        private System.Windows.Forms.Label currentPosLbl;
        private System.Windows.Forms.PictureBox screenRegionPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label guessTxt;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button regionSelectBtn;
        private System.Windows.Forms.PictureBox regionSelectPB;
    }
}

