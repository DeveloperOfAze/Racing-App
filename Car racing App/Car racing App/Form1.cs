using System.Media;

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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox1.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label4.Visible= false;
            pictureBox4.Visible=false;
            comboBox1.Visible = false;
            button2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string texmin = comboBox1.Text;
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            int widthHorse = pictureBox1.Width;
            int widthRabbit = pictureBox2.Width;
            int widthDog=pictureBox3.Width;
            int start = label7.Left;
            pictureBox1.Left = pictureBox1.Left + rnd.Next(0, 5);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(0, 5);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(0, 5);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "At Birincidir";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Canavar Irelileyir";
            }


            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "It birinci oldu";
            }

            if (widthHorse + pictureBox1.Left >= start)
            {  
                timer1.Enabled = false;
                label6.Text = "At Yarisi Qazandi";
            }
            if (widthHorse + pictureBox1.Left >= start && texmin == "At")
            {

                MessageBox.Show(ad + soyad + "Siz Qazandiniz");
            }
            if (label6.Text == "At Yarisi Qazandi" && texmin != "At")
            {
                MessageBox.Show(ad + soyad + "Siz Qazanmadiniz");

            }
            if (widthRabbit + pictureBox2.Left >= start)
            {
                timer1.Enabled = false;
                label6.Text = "Canavar Yarisi Qazandi";
            }

            if (widthRabbit + pictureBox2.Left >= start &&  texmin == "Canavar")
            {
                MessageBox.Show(ad + soyad + "Siz Qazandiniz");
            }
            if (label6.Text == "Canavar Yarisi Qazandi" && texmin != "Canavar")
            {
                MessageBox.Show(ad + soyad + "Siz Qazanmadiniz");

            }
            if (widthDog + pictureBox3.Left >= start)
            {
                timer1.Enabled = false;
                label6.Text = "It Yarisi Qazandi";
            }
            if (widthDog + pictureBox3.Left >= start && texmin == "It" )
            {
                MessageBox.Show(ad + soyad + "Siz Qazandiniz");
            }
            if(label6.Text== "It Yarisi Qazandi" && texmin != "It")
            {
                MessageBox.Show(ad + soyad + "Siz Qazanmadiniz");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeftHorse = pictureBox1.Left;
            LeftRabbit =pictureBox2.Left;
            LeftDog = pictureBox3.Left; 


                    
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ehed\Downloads\electronic-future-beats-117997.wav");
            simpleSound.Play();
        
        }


    }
}
