namespace PrimerEjercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumarButton_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(numero1TextBox.Text);
            int num2 = Convert.ToInt32(numero2TextBox.Text);

            //Sumar(num1, num2);
            resultadoTextBox.Text = Sumar(num1, num2).ToString();
        }

        private int Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
            //return num1 + num2;
        }

        private void MostrarMensaje()
        {
            MessageBox.Show("Esto es un mensaje");
        }

        private void mostrarButton_Click(object sender, EventArgs e)
        {
            MostrarMensaje();
        }

    }
}