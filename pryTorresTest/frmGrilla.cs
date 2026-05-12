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
    public partial class frmGrilla : Form
    {
        

        public frmGrilla()
        {
            InitializeComponent();
        }

        public string tipo;
        public bool envio;
        public bool instalacion;
        public bool garantia;

        public string Informacion
        {
            get { return lblInformacion.Text; }
            set { lblInformacion.Text = value; }
        }

        private void frmGrilla_Load(object sender, EventArgs e)
        {
            double Precio = 0;

            if (tipo == "EQUIPO")
            {
                Precio = 1000000;
            }
            else
            {
                Precio = 350000;
            }

            
            double total = Precio;

            if (envio)
                total += (Precio * 0.05);

            if (instalacion)
                total += (Precio * 0.15);

            if (garantia)
                total += (Precio * 0.20);

            double iva = total * 0.21;
            double final = total + iva;

            lblInformacion.Text =
                "Base: " + Precio + "\n" +
                "Total sin IVA: " + total + "\n" +
                "IVA: " + iva + "\n" +
                "Final: " + final;
        }
    }
}
