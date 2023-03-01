namespace Car_racing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int LeftDog, LeftRabbit, LeftHorse;
        Random rnd = new Random();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int widthHorse = pictureBox1.Left;
            int widthRabbit = pictureBox2.Left;
            int widthDog=pictureBox3.Left;
            int start = label4.Left;
            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 16);

            if (pictureBox1.Left > pictureBox2.Left+5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "At Birincidir";
            }

            if (pictureBox2.Left > pictureBox1.Left+5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Canavar Irelileyir";
            }


            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "It birinci oldu";
            }

            if (widthHorse + pictureBox1.Left >= start)
            {
                timer1.Enabled = false;
                label6.Text = "At Yarisi Qazandi";
            }
            if (widthRabbit + pictureBox2.Left >= start)
            {
                timer1.Enabled = false;
                label6.Text = "Canavar Yarisi Qazandi";
            }

            if (widthDog + pictureBox3.Left >= start)
            {
                timer1.Enabled = false;
                label6.Text = "It Yarisi Qazandi";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeftHorse = pictureBox1.Left;
            LeftRabbit =pictureBox2.Left;
            LeftDog = pictureBox3.Left; 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}