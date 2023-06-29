using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIE1_SalasFranciscp
{
    public partial class frmCargaProductos : Form
    {
        string[,] matProductos = new string[5,3];
        int indiceFila = 0;

        public frmCargaProductos()
        {
            InitializeComponent();
        }

        private void gbRegistros_Enter(object sender, EventArgs e)
        {

        }

        private void frmCargaProductos_Load(object sender, EventArgs e)
        {
        
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            

            if (indiceFila > 4)
            {
                MessageBox.Show("No se pueden almacenar mas productos, Stock lleno", "Stock lleno!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                matProductos[indiceFila, 0] = txtID.Text;
                matProductos[indiceFila, 1] = txtNombre.Text;
                if (dtpRegistro.Value < DateTime.Today)
                {
                    MessageBox.Show("La fecha de registro debe ser una fecha actual", "Fecha Incorrecta!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    matProductos[indiceFila, 2] = dtpRegistro.ToString();
                }
                indiceFila++;
            }


            txtID.Text = "";
            txtNombre.Text = "";
            dtpRegistro.Value = DateTime.Today;

        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            dtpRegistro.Value = DateTime.Today;
        }
    }
}
