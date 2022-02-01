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
    public partial class FuncionesFecha : Form
    {
        public FuncionesFecha()
        {
            InitializeComponent();
        }

        private void procesarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker.Value;

            diaTextBox.Text = fecha.Day.ToString();
            mesTextBox.Text = fecha.Month.ToString();
            anioTextBox.Text = fecha.Year.ToString();

            diaLetrasTextBox.Text = fecha.ToString("dddd");//formatos
            mesLetrasTextBox.Text = fecha.ToString("MMMM");
                                    //también para restar -25
            sumaRestaTextBox.Text = fecha.AddDays(25).ToShortDateString();

            edadTextBox.Text = DevolverEdad(fecha).ToString();

        }

        private int DevolverEdad(DateTime _fechaNacimiento)//función para dovolver la edad según fecha seleccionada
        {
            DateTime fechaNacimiento = _fechaNacimiento;
            DateTime fechaActual = DateTime.Now;

            int edad = 0;

            if (fechaNacimiento > fechaActual)
            {
                MessageBox.Show("! La fecha de nacimiento es mayor a la actual.");
                return 0;
            }
            {//else
                edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
            }
            return edad;
        }//fin función

    }
}
