using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kahootify
{
    public partial class Main : Form
    {
        Timer analysisTimer = new Timer();
        Timer mousePosTimer = new Timer() { Interval = 100 };
        Regex validCoord = new Regex("^[0-9]+( )?,( )?[0-9]+$");
        public string guess = "";

        public Main()
        {
            InitializeComponent();
            analysisTimer.Interval = 1000;
            analysisTimer.Tick += analyzeScreen;
            mousePosTimer.Tick += updateMousePos;
            mousePosTimer.Start();
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
            //Are the coordinates valid?
            if (!validCoord.IsMatch(tlcTxt.Text) || !validCoord.IsMatch(brcTxt.Text))
            {
                MessageBox.Show("Invalid screen coordinates given. Must be in form 'num, num'.");
                analysisTimer.Stop();
                stopAnalysisBtn_Click(this, null);
                return;
            }

            //Get rectangle out.
            string[] topLeftNums = tlcTxt.Text.Replace(" ", "").Split(',');
            string[] bottomRightNums = brcTxt.Text.Replace(" ", "").Split(',');
            int[] nums = { 
                               int.Parse(topLeftNums[0]), int.Parse(topLeftNums[1]),
                               int.Parse(bottomRightNums[0]), int.Parse(bottomRightNums[1])
                             };

            //Get the correct portion of the screen.
            var rect = new Rectangle(nums[0], nums[1], nums[2] - nums[0], nums[3] - nums[1]);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.X, rect.Y, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
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
    }
}
