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

            
            cbRepuesto.CheckedChanged += Tipo_CheckedChanged;
            cbEquipo.CheckedChanged += Tipo_CheckedChanged;
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
                MessageBox.Show("Debe ingresar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre1.Focus();
                return;
            }

            gbListaProductos.Items.Add(tbNombre1.Text);

            // Confirmacion para registro exitoso
            MessageBox.Show("Nombre registrado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                //Confirmacion para registro exitoso con enter
                MessageBox.Show("Nombre registrado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbNombre1.Clear();
                tbNombre1.Focus();
                return;
            }
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            
            if (gbListaProductos.Items.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre1.Focus();
                return;
            }

            
            cbProductos.Items.Clear();
            foreach (var item in gbListaProductos.Items)
            {
                cbProductos.Items.Add(item);
            }
            if (cbProductos.Items.Count > 0)
            {
                cbProductos.SelectedIndex = 0;
            }


            gbDos.Visible = true;
        }
        

        private void btnSiguienteDos_Click(object sender, EventArgs e)
        {
           
            if (cbProductos.Items.Count == 0)
            {
                MessageBox.Show("No hay productos para seleccionar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var info = new StringBuilder();
            info.AppendLine("Producto: " + (cbProductos.SelectedItem?.ToString() ?? string.Empty));

            // Tipos
            var tipos = new List<string>();
            if (cbRepuesto.Checked) tipos.Add("Repuesto");
            if (cbEquipo.Checked) tipos.Add("Equipo");
            if (tipos.Count > 0)
            {
                info.AppendLine("Tipo: " + string.Join(", ", tipos));
            }

            // Adicionales
            var adicionales = new List<string>();
            if (cbInstalacion.Checked) adicionales.Add("Instalación");
            if (cbEnvio.Checked) adicionales.Add("Envío");
            if (cbGarantia.Checked) adicionales.Add("Garantía");
            if (adicionales.Count > 0)
            {
                info.AppendLine("Adicional: " + string.Join(", ", adicionales));
            }

            
            var grilla = new frmGrilla();
            grilla.Informacion = info.ToString();
            grilla.Show();
        }

        private void tbNombre1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gbListaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCargaProducto_Load_1(object sender, EventArgs e)
        {
            
            gbDos.Visible = false;
        }

        private void gbTipo_Enter(object sender, EventArgs e)
        {

        }

        
        private void Tipo_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            if (cb == null) return;

            
            if (!cb.Checked) return;

            
            if (cb == cbRepuesto)
            {
                cbEquipo.Checked = false;
            }
            else if (cb == cbEquipo)
            {
                cbRepuesto.Checked = false;
            }
        }
    }
}
