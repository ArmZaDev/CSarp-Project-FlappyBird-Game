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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            lblScore.Text = StartGame.setValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartMenu Restart = new StartMenu();
            Restart.Show();
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
