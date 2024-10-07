using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carousel
{
    public partial class Form1 : Form
    {
        List<Image> images = new List<Image>();
        int imageIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            images.Add(Image.FromFile("C:\\Users\\NPGC LAB 4\\Desktop\\Carousel\\image1.jpg"));
            images.Add(Image.FromFile("C:\\Users\\NPGC LAB 4\\Desktop\\Carousel\\image2.jpg"));
            images.Add(Image.FromFile("C:\\Users\\NPGC LAB 4\\Desktop\\Carousel\\image3.jpg"));
            images.Add(Image.FromFile("C:\\Users\\NPGC LAB 4\\Desktop\\Carousel\\image4.jpg"));
            imageIndex = 0;
            pictureBox1.Image = images[imageIndex];
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            imageIndex++;
            imageIndex %= 4;
            pictureBox1.Image = images[imageIndex];
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            imageIndex--;
            if (imageIndex < 0) imageIndex = 3;
            pictureBox1.Image = images[imageIndex];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imageIndex++;
            imageIndex %= 4;
            pictureBox1.Image = images[imageIndex];
        }
    }
}
