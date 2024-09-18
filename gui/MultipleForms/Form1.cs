namespace MultipleForms
{
    public partial class Form1 : Form
    {
        int radius = 500;
        double x_incr, y_incr;
        int angle = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            FormFactorial formFactorial = new FormFactorial();
            formFactorial.ShowDialog();
            //this.Close();
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            FormPrime formPrime = new FormPrime();
            formPrime.ShowDialog();
            //this.Close();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            FormFibonacci formFibonacci = new FormFibonacci();
            formFibonacci.ShowDialog();
            //this.Close();
        }

        private void btnValidEmail_Click(object sender, EventArgs e)
        {
            FormValidEmail formValidEmail = new FormValidEmail();
            formValidEmail.ShowDialog();
            //this.Close();
        }

        /*
        private void btnCircle_Click(object sender, EventArgs e)
        { 
            int currLocX = lblCirc.Location.X;
            int currLocY = lblCirc.Location.Y;
            while (true)
            {
                x_incr =  Math.Cos(angle * (2*Math.PI / 360));
                y_incr = Math.Sin(angle * (2 * Math.PI / 360));

                lblCirc.SetBounds(Convert.ToInt32(currLocX + x_incr), Convert.ToInt32(currLocY + y_incr), 500, 500);
                angle++;
                angle = angle % 360;
            }
        }
        */
    }
}
