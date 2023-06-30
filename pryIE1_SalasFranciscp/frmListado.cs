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
    public partial class frmListado : Form
    {
        string a;
        string[,] matriz;
        public frmListado(string a, string[,] matriz)
        {
            InitializeComponent();

            if (a == "Ventas")
            {
                
                this.Text = "Listado de Ventas";
                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    if (matriz[f, 0] != null)
                    {
                        lstDatos.Items.Add("Ventas " + (f, +1).ToString());
                        lstDatos.Items.Add(" ID: " + matriz[f, 0] + " Producto: " + matriz[f, 1] + " Cantidad: " + matriz[f, 2] + " Fecha:" + matriz[f, 3]);
                    }
                }
            }
            if (a == "Productos")
            {

                this.Text = "Listado de Productos";

                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    if (matriz[f, 0] != null)
                    {
                        lstDatos.Items.Add("Producto " + (f, +1).ToString());
                        lstDatos.Items.Add(" ID: " + matriz[f, 0] + " Nombre: " + matriz[f, 1] + " Fecha: " + matriz[f, 2]);
                    }
                }
            }
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        { 
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
