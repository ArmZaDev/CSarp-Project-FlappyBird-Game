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
    public partial class StartGame : Form
    {

        bool jumping;
        int pipeSpeed = 5;
        int gravity = 3;
        int Score = 0;

        public static string setValue = "";

        public StartGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            score.Text = Score.ToString();

            pipeTop.Left -= pipeSpeed;
            pipeButtom.Left -= pipeSpeed;

            ground.Left -= pipeSpeed;
            collisionAndScore();
        }

        private void StartGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {               
                jumping = true;
                gravity = -8;
            }        
        }

        private void StartGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = -2;
            }
        }

        public void EndGame()
        {
            timer1.Stop();
            score.Text = Score.ToString();
            GameOver gameOver = new GameOver();
            gameOver.Show();
            this.Hide();
        }

        public void collisionAndScore()
        {
            if (ground.Left < -50)
            {
                ground.Left = 0;
            }
            
            if (pipeTop.Left < -90)
            {
                pipeTop.Left = 700;
                Score++;
            }
            if (pipeButtom.Left < -100)
            {
                pipeTop.Left = 700;
                Score++;
            }

            if (Score >= 15)
            {
                timer1.Stop();
                NextLevel nextLevel = new NextLevel();
                nextLevel.Show();
                this.Hide();
            }

            else if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                EndGame();
            }
            else if(flappyBird.Bounds.IntersectsWith(pipeButtom.Bounds))
            {
                EndGame();
            }
        }
    }
}
