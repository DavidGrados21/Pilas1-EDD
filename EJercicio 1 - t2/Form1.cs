using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJercicio_1___t2
{
    public partial class Form1 : Form
    {
        Pila pila = new Pila();
        Pila aux = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtDato.Text);
                txtDato.Clear();
                txtDato.Focus();
                pila.push(x);
                pila.mostrar(lstDatos);
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDato.Clear();
                txtDato.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(numericUpDown1.Value.ToString());
            pila.desapilar(num, lstDatos, aux);
        }

        private void btnfondo_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();
            MessageBox.Show("El dato que esta en el fondo es" + pila.Fondo(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
