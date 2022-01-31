using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerEjercicio
{
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void procesarButton_Click(object sender, EventArgs e)
        {
            String cadena = cadenaTextBox.Text;
            longitudTextBox.Text = cadena.Length.ToString();
            //o//Convert.ToString(cadena.Length);
            primerCaracterTextBox.Text = cadena.Substring(0, 1);
            utlimoCaracterTextBox.Text = cadena.Substring(cadena.Length - 1, 1);
            mayusculasTextBox.Text = cadena.ToUpper();
            minusculasTextBox.Text = cadena.ToLower();
            reemplazarTextBox.Text = cadena.Replace(" ", "-");
        }
    }
}
