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
    public partial class frmCargaVentas : Form
    {
        public string[,] matVentas = new string[5, 4];
        int indiceFila = 0;

        public frmCargaVentas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdConsulta_Click(object sender, EventArgs e)
        {
            int f = 0;
            while (f < matVentas.GetLength(0))
            {
                if (matVentas[f, 0] != null)
                {
                    if (int.Parse(matVentas[f, 3]) == int.Parse(txtConsultaCantidad.Text))
                    {
                        dgvConsultas.Rows.Add(matVentas[f, 0],
                         matVentas[f, 1], matVentas[f, 2], matVentas[f, 3]);

                    }
                }
                f++;
            }
            txtConsultaCantidad.Text = "";
        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (indiceFila > 4)
            {
                MessageBox.Show("No se pueden cargar mas ventas", "Ventas completas!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                matVentas[indiceFila, 0] = txtID.Text;
                matVentas[indiceFila, 1] = txtNombre.Text;
                matVentas[indiceFila, 2] = dtpVenta.Value.ToString();
                matVentas[indiceFila, 3] = txtCantidad.Text;
                indiceFila++;

                txtID.Text = "";
                txtNombre.Text = "";
                dtpVenta.Value = DateTime.Today;
                txtCantidad.Text = "0";

            }

            
        }

        private void txtConsultaCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultas.Rows.Clear();
        }

        private void cmdConsulta1_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (c < matVentas.GetLength(0))
            {
                if (matVentas[c, 0] != null)
                {
                    if (matVentas[c, 1] == txtConsultaNombre.Text)
                    {
                        dgvConsultas.Rows.Add(matVentas[c, 0],
                         matVentas[c, 1], matVentas[c, 2], matVentas[c, 3]);

                    }
                    else
                    {
                        MessageBox.Show("No se encontro Venta!", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                c++;
            }
            txtConsultaNombre.Text = "";
        }
    }   

}
