namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        int ballSpeedX = 4;
        int ballSpeedY = 4;
        int speed = 2;

        Random rand = new Random();
        bool goDown, goUp;
        int computerSpeedChange = 50;
        int playerScore = 0;
        int computersScore = 0;
        int playerSpeed = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void CheckCollision(PictureBox Player, PictureBox Computer, int offset)
        {

        }
        private void GameOver(string message)
        {

        }
    }
}
