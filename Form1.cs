namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double IMC, altura, peso;
            altura = double.Parse(txtAltura.Text);
            peso = double.Parse(txtPeso.Text);

            IMC = peso / (altura * altura);
            MessageBox.Show("Tu IMC es: " +IMC+" Resultado del IMC: "+MessageBoxButtons.OK);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}