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

        private void btnRegistrar1_Click(object sender, EventArgs e)
        {
            
            if (tbNombre1.Text == "")
            {
                MessageBox.Show("Debe ingresar un producto.");
                tbNombre1.Focus();
                return;
            }

            gbListaProductos.Items.Add(tbNombre1.Text);
            tbNombre1.Clear();
            tbNombre1.Focus();
        }

        private void tbNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && tbNombre1.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre1.Focus();
                return;
            }
            if (e.KeyChar == 13)
            { 
                gbListaProductos.Items.Add(tbNombre1.Text);
                tbNombre1.Clear();
                tbNombre1.Focus();
                return;
            }
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
           
                
            }
        

        private void btnSiguienteDos_Click(object sender, EventArgs e)
        {
           
        }

        private void tbNombre1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gbListaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
