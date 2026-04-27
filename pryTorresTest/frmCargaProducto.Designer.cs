namespace pryTorresTest
{
    partial class frmCargaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProducto));
            this.lblNombreUno = new System.Windows.Forms.Label();
            this.lblListaProducto = new System.Windows.Forms.Label();
            this.btnSiguiente1 = new System.Windows.Forms.Button();
            this.tbNombre1 = new System.Windows.Forms.TextBox();
            this.gbListaProductos = new System.Windows.Forms.ComboBox();
            this.btnRegistrar1 = new System.Windows.Forms.Button();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.gbDos = new System.Windows.Forms.GroupBox();
            this.btnSiguienteDos = new System.Windows.Forms.Button();
            this.gbAdicional = new System.Windows.Forms.GroupBox();
            this.cbGarantia = new System.Windows.Forms.CheckBox();
            this.cbEnvio = new System.Windows.Forms.CheckBox();
            this.cbInstalacion = new System.Windows.Forms.CheckBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.cbEquipo = new System.Windows.Forms.CheckBox();
            this.cbRepuesto = new System.Windows.Forms.CheckBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.gbProductos.SuspendLayout();
            this.gbDos.SuspendLayout();
            this.gbAdicional.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreUno
            // 
            this.lblNombreUno.AutoSize = true;
            this.lblNombreUno.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUno.Location = new System.Drawing.Point(28, 28);
            this.lblNombreUno.Name = "lblNombreUno";
            this.lblNombreUno.Size = new System.Drawing.Size(63, 20);
            this.lblNombreUno.TabIndex = 0;
            this.lblNombreUno.Text = "Nombre:";
            // 
            // lblListaProducto
            // 
            this.lblListaProducto.AutoSize = true;
            this.lblListaProducto.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProducto.Location = new System.Drawing.Point(28, 113);
            this.lblListaProducto.Name = "lblListaProducto";
            this.lblListaProducto.Size = new System.Drawing.Size(102, 20);
            this.lblListaProducto.TabIndex = 1;
            this.lblListaProducto.Text = "Lista Producto";
            // 
            // btnSiguiente1
            // 
            this.btnSiguiente1.Location = new System.Drawing.Point(141, 149);
            this.btnSiguiente1.Name = "btnSiguiente1";
            this.btnSiguiente1.Size = new System.Drawing.Size(128, 23);
            this.btnSiguiente1.TabIndex = 3;
            this.btnSiguiente1.Text = "Siguiente";
            this.btnSiguiente1.UseVisualStyleBackColor = true;
            this.btnSiguiente1.Click += new System.EventHandler(this.btnSiguiente1_Click);
            // 
            // tbNombre1
            // 
            this.tbNombre1.Location = new System.Drawing.Point(141, 28);
            this.tbNombre1.Name = "tbNombre1";
            this.tbNombre1.Size = new System.Drawing.Size(128, 20);
            this.tbNombre1.TabIndex = 0;
            this.tbNombre1.TextChanged += new System.EventHandler(this.tbNombre1_TextChanged_1);
            this.tbNombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre1_KeyPress);
            // 
            // gbListaProductos
            // 
            this.gbListaProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gbListaProductos.FormattingEnabled = true;
            this.gbListaProductos.Location = new System.Drawing.Point(141, 112);
            this.gbListaProductos.Name = "gbListaProductos";
            this.gbListaProductos.Size = new System.Drawing.Size(128, 21);
            this.gbListaProductos.TabIndex = 2;
            this.gbListaProductos.SelectedIndexChanged += new System.EventHandler(this.gbListaProductos_SelectedIndexChanged);
            // 
            // btnRegistrar1
            // 
            this.btnRegistrar1.Location = new System.Drawing.Point(141, 69);
            this.btnRegistrar1.Name = "btnRegistrar1";
            this.btnRegistrar1.Size = new System.Drawing.Size(128, 22);
            this.btnRegistrar1.TabIndex = 1;
            this.btnRegistrar1.Text = "Registrar";
            this.btnRegistrar1.UseVisualStyleBackColor = true;
            this.btnRegistrar1.Click += new System.EventHandler(this.btnRegistrar1_Click);
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.lblNombreUno);
            this.gbProductos.Controls.Add(this.btnRegistrar1);
            this.gbProductos.Controls.Add(this.lblListaProducto);
            this.gbProductos.Controls.Add(this.gbListaProductos);
            this.gbProductos.Controls.Add(this.btnSiguiente1);
            this.gbProductos.Controls.Add(this.tbNombre1);
            this.gbProductos.Location = new System.Drawing.Point(12, 12);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(310, 186);
            this.gbProductos.TabIndex = 6;
            this.gbProductos.TabStop = false;
            this.gbProductos.Enter += new System.EventHandler(this.gbProductos_Enter);
            // 
            // gbDos
            // 
            this.gbDos.Controls.Add(this.btnSiguienteDos);
            this.gbDos.Controls.Add(this.gbAdicional);
            this.gbDos.Controls.Add(this.gbTipo);
            this.gbDos.Controls.Add(this.cbProductos);
            this.gbDos.Controls.Add(this.lblProducto);
            this.gbDos.Location = new System.Drawing.Point(12, 221);
            this.gbDos.Name = "gbDos";
            this.gbDos.Size = new System.Drawing.Size(310, 303);
            this.gbDos.TabIndex = 6;
            this.gbDos.TabStop = false;
            this.gbDos.Visible = false;
            // 
            // btnSiguienteDos
            // 
            this.btnSiguienteDos.Location = new System.Drawing.Point(76, 257);
            this.btnSiguienteDos.Name = "btnSiguienteDos";
            this.btnSiguienteDos.Size = new System.Drawing.Size(158, 23);
            this.btnSiguienteDos.TabIndex = 0;
            this.btnSiguienteDos.Text = "Siguiente";
            this.btnSiguienteDos.UseVisualStyleBackColor = true;
            this.btnSiguienteDos.Click += new System.EventHandler(this.btnSiguienteDos_Click);
            // 
            // gbAdicional
            // 
            this.gbAdicional.Controls.Add(this.cbGarantia);
            this.gbAdicional.Controls.Add(this.cbEnvio);
            this.gbAdicional.Controls.Add(this.cbInstalacion);
            this.gbAdicional.Location = new System.Drawing.Point(32, 135);
            this.gbAdicional.Name = "gbAdicional";
            this.gbAdicional.Size = new System.Drawing.Size(237, 103);
            this.gbAdicional.TabIndex = 3;
            this.gbAdicional.TabStop = false;
            this.gbAdicional.Text = "Adicional";
            // 
            // cbGarantia
            // 
            this.cbGarantia.AutoSize = true;
            this.cbGarantia.Location = new System.Drawing.Point(26, 69);
            this.cbGarantia.Name = "cbGarantia";
            this.cbGarantia.Size = new System.Drawing.Size(68, 17);
            this.cbGarantia.TabIndex = 2;
            this.cbGarantia.Text = "Garantía";
            this.cbGarantia.UseVisualStyleBackColor = true;
            // 
            // cbEnvio
            // 
            this.cbEnvio.AutoSize = true;
            this.cbEnvio.Location = new System.Drawing.Point(122, 35);
            this.cbEnvio.Name = "cbEnvio";
            this.cbEnvio.Size = new System.Drawing.Size(55, 17);
            this.cbEnvio.TabIndex = 1;
            this.cbEnvio.Text = "Envío";
            this.cbEnvio.UseVisualStyleBackColor = true;
            // 
            // cbInstalacion
            // 
            this.cbInstalacion.AutoSize = true;
            this.cbInstalacion.Location = new System.Drawing.Point(26, 35);
            this.cbInstalacion.Name = "cbInstalacion";
            this.cbInstalacion.Size = new System.Drawing.Size(77, 17);
            this.cbInstalacion.TabIndex = 0;
            this.cbInstalacion.Text = "Instalación";
            this.cbInstalacion.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.cbEquipo);
            this.gbTipo.Controls.Add(this.cbRepuesto);
            this.gbTipo.Location = new System.Drawing.Point(32, 77);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(237, 52);
            this.gbTipo.TabIndex = 2;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // cbEquipo
            // 
            this.cbEquipo.AutoSize = true;
            this.cbEquipo.Location = new System.Drawing.Point(122, 20);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(59, 17);
            this.cbEquipo.TabIndex = 1;
            this.cbEquipo.Text = "Equipo";
            this.cbEquipo.UseVisualStyleBackColor = true;
            // 
            // cbRepuesto
            // 
            this.cbRepuesto.AutoSize = true;
            this.cbRepuesto.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbRepuesto.Location = new System.Drawing.Point(26, 20);
            this.cbRepuesto.Name = "cbRepuesto";
            this.cbRepuesto.Size = new System.Drawing.Size(72, 17);
            this.cbRepuesto.TabIndex = 0;
            this.cbRepuesto.Text = "Repuesto";
            this.cbRepuesto.UseVisualStyleBackColor = true;
            // 
            // cbProductos
            // 
            this.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(141, 28);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(128, 21);
            this.cbProductos.TabIndex = 4;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(28, 30);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(68, 20);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // frmCargaProducto
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(343, 552);
            this.Controls.Add(this.gbDos);
            this.Controls.Add(this.gbProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaProducto";
            this.Text = "Carga Producto";
            this.Load += new System.EventHandler(this.frmCargaProducto_Load_1);
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            this.gbDos.ResumeLayout(false);
            this.gbDos.PerformLayout();
            this.gbAdicional.ResumeLayout(false);
            this.gbAdicional.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblNombreUno;
        private System.Windows.Forms.Label lblListaProducto;
        private System.Windows.Forms.Button btnSiguiente1;
        private System.Windows.Forms.TextBox tbNombre1;
        private System.Windows.Forms.ComboBox gbListaProductos;
        private System.Windows.Forms.Button btnRegistrar1;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.GroupBox gbDos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox gbAdicional;
        private System.Windows.Forms.CheckBox cbInstalacion;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.CheckBox cbEquipo;
        private System.Windows.Forms.CheckBox cbRepuesto;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Button btnSiguienteDos;
        private System.Windows.Forms.CheckBox cbGarantia;
        private System.Windows.Forms.CheckBox cbEnvio;
    }
}