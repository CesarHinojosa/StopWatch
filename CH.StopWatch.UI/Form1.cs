using CH.StopWatch.BL;
using System.Drawing.Text;

namespace CH.StopWatch.UI
{
    public partial class Form1 : Form
    {
        private StartStop startstop = new StartStop();

        public Form1()
        {
            InitializeComponent();
            lblDisplay.Text = "00:00:00";
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Timer.Enabled = true;
                startstop.StartingClock();
            }
            catch (StartTimeException ste)
            {
                MessageBox.Show(ste.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                Timer.Enabled = false;
                startstop.StopClock();
            }
            catch (StopTimeException ste)
            {
                MessageBox.Show(ste.Message);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = startstop.ElapsedTime.ToString("hh\\:mm\\:ss");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            startstop.Reset();
            lblDisplay.Text = "00:00:00";
        }
    }
}