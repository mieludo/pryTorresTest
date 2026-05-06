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
        /*
         PSEUDOCÓDIGO (plan detallado):
         1. Cambiar los campos 'envio', 'instalacion' y 'garantia' de 'string' a 'bool' para poder usarlos en condiciones if.
         2. En el evento Load:
            a. Inicializar la variable Precio según el tipo seleccionado ("Notebook" o "PC Escritorio").
            b. Calcular 'total' iniciándolo con la 'Precio'.
            c. Si 'envio' es true, añadir 5% de 'Precio' a 'total'.
            d. Si 'instalacion' es true, añadir 15% de 'Precio' a 'total'.
            e. Si 'garantia' es true, añadir 20% de 'Precio' a 'total'.
            f. Calcular IVA (21%) sobre 'total' y sumar a obtener 'final'.
            g. Mostrar los valores en 'lblInformacion'.
         3. Mantener compatibilidad con C# 7.3 y .NET Framework 4.7.2.
        */

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

            // Calcular totales aplicando los flags booleanos
            double total = Precio;

            if (envio)
                total += Precio * 0.05;

            if (instalacion)
                total += Precio * 0.15;

            if (garantia)
                total += Precio * 0.20;

            double iva = total * 0.21;
            double final = total + iva;

            lblInformacion.Text =
                "Base: " + Precio + Environment.NewLine +
                "Total sin IVA: " + total + Environment.NewLine +
                "IVA: " + iva + Environment.NewLine +
                "Final: " + final;
        }
    }
}
