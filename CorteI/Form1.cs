using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorteI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombres = tbNombres.Text;
            string apellidos = tbApellidos.Text;
            DateTime fechaNacimiento;


            if (!DateTime.TryParse(tbFechaNacimiento.Text, out fechaNacimiento))
            {
                MessageBox.Show("Ingrese una fecha de nacimiento válida.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ciudad = tbCiudad.Text;

            Persona persona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);


            if (i < MAX)
            {

                personas[i] = persona;
                i++;

                MessageBox.Show("Persona agregada con éxito.", "Puntos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pueden agregar más personas", "Puntos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}