namespace Car_Race_Game
{
    public partial class Form1 : Form
    {
        private int speed = 3;
        private int score = 0;
        private int height = 1033;
        private int width = 438;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11 };

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Top += 2;
                // Set the specific value based on the pictureBox
                if (pictureBox == pictureBox1 || pictureBox == pictureBox3 || pictureBox == pictureBox4 || pictureBox == pictureBox5)
                {
                    if (pictureBox.Top > (height - 129))
                    {
                        pictureBox.Top = -129;
                    }
                }
                else
                {
                    if (pictureBox.Top > (height - 85))
                    {
                        pictureBox.Top = -85;
                    }
                }
            }

            //Pedestrian Movement
            Pedestrian.Top += 2;

            if (Pedestrian.Top > (height - 150))
            {
                Pedestrian.Top = -150;
            }

            Pedestrian.Left += 1;

            if (Pedestrian.Left > (438))
            {
                Pedestrian.Left = -100;
            }
            //Checking Pedestrian collision
            if (Car.Bounds.IntersectsWith(Pedestrian.Bounds))
            {
                Pedestrian.Top -= height;
                score -= 5;
            }

            //Checking Coin collision
            if (Car.Bounds.IntersectsWith(Coin1.Bounds))
            {
                Coin1.Top -= height;
                score += 1;
            }
            if (Car.Bounds.IntersectsWith(Coin2.Bounds))
            {
                Coin2.Top -= height;
                score += 1;
            }
            //Coin Animation
            Coin1.Top += 2;
            Coin2.Top += 2;

            if (Coin1.Top > (height - 75))
            {
                Coin1.Top = -75;
            }
            if (Coin2.Top > (height - 75))
            {
                Coin2.Top = -75;
            }
            label1.Text = "Speed: " + speed.ToString();
            label2.Text = "Score: " + score.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'q' || e.KeyChar == 'Q')
            {
                speed -= 3;
            }
            if (e.KeyChar == 'e' || e.KeyChar == 'E')
            {
                speed += 3;
            }
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
            {
                Car.Left -= speed;
            }
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
            {
                Car.Left += speed;
            }
            if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                Car.Top += speed + 2;
            }
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                Car.Top -= speed;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
   
