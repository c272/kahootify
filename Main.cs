using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kahootify
{
    public partial class Main : Form
    {
        //Timers for repeated events.
        Timer analysisTimer = new Timer();
        Timer mousePosTimer = new Timer() { Interval = 100 };
        Rectangle regionRect = default;
        public string guess = "";

        //Mouse position variables for region selection.
        int selectX, selectY, selectWidth, selectHeight;
        public Pen selectPen;

        //This variable control when you start the right click
        bool startedClicking = false;

        public Main()
        {
            InitializeComponent();

            //Start timers for repeated events.
            analysisTimer.Interval = 1000;
            analysisTimer.Tick += analyzeScreen;
            mousePosTimer.Tick += updateMousePos;
            mousePosTimer.Start();

            //Hide the region select picture box.
            regionSelectPB.Hide();

            //Disable the "start analysis" button (no region).
            startAnalysisBtn.Enabled = false;
        }

        /// <summary>
        /// Updates the labelled mouse position.
        /// </summary>
        private void updateMousePos(object sender, EventArgs e)
        {
            currentPosLbl.Text = "Current mouse position: " + Cursor.Position.ToString();
        }

        /// <summary>
        /// Analyzes the current screen region and determines the question.
        /// </summary>
        private void analyzeScreen(object sender, EventArgs e)
        {
            //Has a region been selected yet?
            if (regionRect == default(Rectangle)) { return; }

            //Get screen area out.
            Bitmap bmp = new Bitmap(regionRect.Width, regionRect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(regionRect.X, regionRect.Y, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            screenRegionPB.Image = bmp;

            //OCR.
            var ocr = new IronOcr.AutoOcr();
            var result = ocr.Read(bmp);
            guess = result.Text;
            if (result.Text == null || result.Text == "")
            {
                guessTxt.Text = "Current best guess is no text is showing.";
                searchBtn.Enabled = false;
            }
            else 
            { 
                guessTxt.Text = "Current best guess is \"" + guess + "\".";
                searchBtn.Enabled = true;
            }
        }
        
        //Start the timer.
        private void startAnalysisBtn_Click(object sender, EventArgs e)
        {
            analysisTimer.Start();
            statusLbl.Text = "Current status: ANALYZING.";
        }

        //Stop the timer.
        private void stopAnalysisBtn_Click(object sender, EventArgs e)
        {
            analysisTimer.Stop();
            statusLbl.Text = "Current status: OFF.";
        }

        /// <summary>
        /// Search the current guess.
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            browser.Navigate("https://www.google.com/search?q=" + guess);
        }

        /// <summary>
        /// Allows the user to select a region of the screen to capture.
        /// </summary>
        private void regionSelectBtn_Click(object sender, EventArgs e)
        {
            //Hide form, make a bitmap of the screen.
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Hide();
            Bitmap screen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            //Create graphics with the bitmap, copy.
            Graphics graphics = Graphics.FromImage((Image)screen);
            graphics.CopyFromScreen(0, 0, 0, 0, screen.Size);

            //Create a temporary memory stream and save the graphics into it, set 
            using (MemoryStream s = new MemoryStream())
            {
                screen.Save(s, ImageFormat.Bmp);
                regionSelectPB.Size = new Size(this.Width, this.Height);
                regionSelectPB.Image = Image.FromStream(s);
            }

            //Show and set cursor.
            regionSelectPB.Show();
            this.Show();
            Cursor = Cursors.Cross;
        }

        /// <summary>
        /// Triggered when the user moves the mouse over the region select box.
        /// </summary>
        private void regionSelect_MouseMove(object sender, MouseEventArgs e)
        {
            //Image exists?
            if (regionSelectPB.Image == null)
            {
                return;
            }

            //Has the user started dragging?
            if (startedClicking)
            {
                //Refresh picture box, set coordinate square corner.
                regionSelectPB.Refresh();
                selectWidth = e.X - selectX;
                selectHeight = e.Y - selectY;
                regionSelectPB.CreateGraphics().DrawRectangle(selectPen, selectX, selectY, selectWidth, selectHeight);
            }
        }
        
        /// <summary>
        /// Triggered when the user clicks down on the region select box.
        /// </summary>
        private void regionSelect_MouseDown(object sender, MouseEventArgs e)
        {
            //Has the user already started clicking?
            if (startedClicking) { return; }

            //Is LMB down?
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                startedClicking = true;

                //Get start coords for rectangle.
                selectX = e.X;
                selectY = e.Y;
                selectPen = new Pen(Color.Red, 1);
                selectPen.DashStyle = DashStyle.DashDotDot;
            }

            //Refresh picture box, start clicking.
            regionSelectPB.Refresh();
            return;
        }

        /// <summary>
        /// Triggered when the user releases a mouse button on the region select box.
        /// </summary>
        private void regionSelect_MouseUp(object sender, MouseEventArgs e)
        {
            //Make sure the user's started to click already.
            if (!startedClicking) { return; }

            //Make sure an image exists.
            if (regionSelectPB.Image == null) { return; }

            //Set the width/height, etc.
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                regionSelectPB.Refresh();
                selectWidth = e.X - selectX;
                selectHeight = e.Y - selectY;
                regionSelectPB.CreateGraphics().DrawRectangle(selectPen, selectX,
                         selectY, selectWidth, selectHeight);

            }
            startedClicking = false;

            //Reset window mode, etc.
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            regionSelectPB.Hide();
            Cursor = Cursors.Default;

            //Set the region rectangle.
            if (selectWidth > 0)
            {
                regionRect = new Rectangle(selectX, selectY, selectWidth, selectHeight);

                //Re-enable analysis button.
                startAnalysisBtn.Enabled = true;
            }
        }
    }
}
