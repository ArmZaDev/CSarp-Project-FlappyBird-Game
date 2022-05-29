using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stupid_Bird
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width = 5;
            if (panel2.Width >= 697)
            {
                timer1.Stop();
                StartGame startGame = new StartGame();
                startGame.Show();
                Hide();
            }
        }
       

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
