using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Stupid_Bird
{
    public partial class StartMenu : Form
    {

        public SoundPlayer backSound = new SoundPlayer(@"C:\Database\Flappy Bird Theme Song.wav");

        public StartMenu()
        {
            backSound.Play();
            InitializeComponent();          
        }
       
        
       

        private void btnStart_Click(object sender, EventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();
            this.Hide();
            backSound.Stop();           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
