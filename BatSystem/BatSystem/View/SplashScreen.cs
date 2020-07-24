using System;
using System.Windows.Forms;

namespace BatSystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            progressBar.Increment(4);
            if (progressBar.Value == 100)
            {
                timer.Enabled = false;
                Login menu = new Login();
                menu.Show();
                this.Hide();
            }
        }
    }
}
