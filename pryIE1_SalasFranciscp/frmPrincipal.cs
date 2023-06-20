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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cdmCargarProducto_Click(object sender, EventArgs e)
        {
            frmCargaProductos f = new frmCargaProductos();
            f.ShowDialog();
        }
    }
}
