using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresTest
{
    public partial class frmCargaProducto : Form
    {
        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void frmCargaProducto_Load(object sender, EventArgs e)
        {

        }

        private void tbNombre1_TextChanged(object sender, EventArgs e)
        {
            if (tbNombre1.Text.Length > 0)
            {
                btnRegistrar1.Enabled = true;
            }
            else
            {
                btnRegistrar1.Enabled = false;
            }
        }

        private void gbProductos_Enter(object sender, EventArgs e)
        {
            
            
            

        }
    }
}
