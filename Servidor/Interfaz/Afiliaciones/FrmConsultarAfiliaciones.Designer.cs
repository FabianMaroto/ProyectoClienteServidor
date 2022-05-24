namespace ServidorFITUNED.Interfaz.Afiliaciones
{
    partial class FrmConsultarAfiliaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvAfiliaciones = new System.Windows.Forms.DataGridView();
            this.IdAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAfiliaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAfiliaciones
            // 
            this.DgvAfiliaciones.AllowUserToAddRows = false;
            this.DgvAfiliaciones.AllowUserToDeleteRows = false;
            this.DgvAfiliaciones.AllowUserToResizeRows = false;
            this.DgvAfiliaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAfiliaciones.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DgvAfiliaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAfiliaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAfiliaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAfiliaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAfiliaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAfiliacion,
            this.FechaAfiliacion,
            this.IdCliente,
            this.NombreCliente,
            this.PrimerApellido,
            this.SegundoApellido,
            this.IdSede,
            this.Nombre,
            this.Estado,
            this.Telefono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAfiliaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAfiliaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAfiliaciones.Location = new System.Drawing.Point(0, 53);
            this.DgvAfiliaciones.MultiSelect = false;
            this.DgvAfiliaciones.Name = "DgvAfiliaciones";
            this.DgvAfiliaciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAfiliaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAfiliaciones.RowHeadersVisible = false;
            this.DgvAfiliaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAfiliaciones.Size = new System.Drawing.Size(1044, 458);
            this.DgvAfiliaciones.TabIndex = 0;
            // 
            // IdAfiliacion
            // 
            this.IdAfiliacion.HeaderText = "ID Afiliación";
            this.IdAfiliacion.Name = "IdAfiliacion";
            this.IdAfiliacion.ReadOnly = true;
            // 
            // FechaAfiliacion
            // 
            this.FechaAfiliacion.HeaderText = "Fecha de Afiliación";
            this.FechaAfiliacion.Name = "FechaAfiliacion";
            this.FechaAfiliacion.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Identificación";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.HeaderText = "Primer apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.HeaderText = "Segundo apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.ReadOnly = true;
            // 
            // IdSede
            // 
            this.IdSede.HeaderText = "ID Sede";
            this.IdSede.Name = "IdSede";
            this.IdSede.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 53);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cliente a consultar:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(153, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 32;
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.ForeColor = System.Drawing.Color.White;
            this.TxtId.Location = new System.Drawing.Point(153, 17);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(250, 20);
            this.TxtId.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(409, 12);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(87, 30);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmConsultarAfiliaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1044, 511);
            this.Controls.Add(this.DgvAfiliaciones);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarAfiliaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar afiliaciones";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAfiliaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAfiliaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnBuscar;
    }
}