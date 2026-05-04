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


        public string Informacion
        {
            get { return lblInformacion.Text; }
            set { lblInformacion.Text = value; }
        }

        private void frmGrilla_Load(object sender, EventArgs e)
        {

        }
    }
}
