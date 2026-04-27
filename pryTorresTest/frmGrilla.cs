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

        // Public property to allow other forms to set the information label
        public string Informacion
        {
            get { return lblInformacion.Text; }
            set { lblInformacion.Text = value; }
        }
    }
}
