namespace Stupid_Bird
{
    partial class NextLevel
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
            this.score = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeButtom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.White;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.score.Location = new System.Drawing.Point(13, 15);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(33, 36);
            this.score.TabIndex = 9;
            this.score.Text = "0";
            // 
            // ground
            // 
            this.ground.Image = global::Stupid_Bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 563);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(795, 106);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 8;
            this.ground.TabStop = false;
            // 
            // pipeButtom
            // 
            this.pipeButtom.BackgroundImage = global::Stupid_Bird.Properties.Resources.BackGround1_copy;
            this.pipeButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeButtom.Image = global::Stupid_Bird.Properties.Resources.pipe;
            this.pipeButtom.Location = new System.Drawing.Point(625, 350);
            this.pipeButtom.Name = "pipeButtom";
            this.pipeButtom.Size = new System.Drawing.Size(118, 305);
            this.pipeButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeButtom.TabIndex = 7;
            this.pipeButtom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackgroundImage = global::Stupid_Bird.Properties.Resources.BackGround1;
            this.pipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeTop.Image = global::Stupid_Bird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(473, -9);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(118, 191);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 6;
            this.pipeTop.TabStop = false;
            // 
            // NextLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stupid_Bird.Properties.Resources.BackGround1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 661);
            this.Controls.Add(this.score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeButtom);
            this.Controls.Add(this.pipeTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NextLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextLevel";
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeButtom;
        private System.Windows.Forms.PictureBox pipeTop;
    }
}