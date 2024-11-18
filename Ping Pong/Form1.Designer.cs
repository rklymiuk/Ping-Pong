namespace Ping_Pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Player = new PictureBox();
            COMPUTER = new PictureBox();
            Ball = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)COMPUTER).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackColor = Color.FromArgb(255, 192, 255);
            Player.BorderStyle = BorderStyle.Fixed3D;
            Player.Location = new Point(12, 158);
            Player.Name = "Player";
            Player.Size = new Size(30, 120);
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // COMPUTER
            // 
            COMPUTER.BackColor = Color.FromArgb(0, 0, 192);
            COMPUTER.BorderStyle = BorderStyle.Fixed3D;
            COMPUTER.Location = new Point(758, 158);
            COMPUTER.Name = "COMPUTER";
            COMPUTER.Size = new Size(30, 120);
            COMPUTER.TabIndex = 1;
            COMPUTER.TabStop = false;
            // 
            // Ball
            // 
            Ball.Image = Properties.Resources.ball;
            Ball.Location = new Point(361, 203);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.SizeMode = PictureBoxSizeMode.StretchImage;
            Ball.TabIndex = 3;
            Ball.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += TimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(Ball);
            Controls.Add(COMPUTER);
            Controls.Add(Player);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Ping Pong";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)COMPUTER).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Player;
        private PictureBox COMPUTER;
        private PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer;
    }
}
