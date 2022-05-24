namespace ServidorFITUNED.Interfaz.Afiliaciones
{
    partial class FrmRegistrarAfiliacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LstClientes = new System.Windows.Forms.ListBox();
            this.LstSedes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtIdSede = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdAfiliacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCampoVacios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clientes disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sedes disponibles";
            // 
            // LstClientes
            // 
            this.LstClientes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LstClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstClientes.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstClientes.ForeColor = System.Drawing.Color.White;
            this.LstClientes.FormattingEnabled = true;
            this.LstClientes.ItemHeight = 19;
            this.LstClientes.Location = new System.Drawing.Point(12, 32);
            this.LstClientes.Name = "LstClientes";
            this.LstClientes.Size = new System.Drawing.Size(428, 171);
            this.LstClientes.TabIndex = 16;
            this.LstClientes.SelectedIndexChanged += new System.EventHandler(this.LstClientes_SelectedIndexChanged);
            // 
            // LstSedes
            // 
            this.LstSedes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LstSedes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstSedes.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstSedes.ForeColor = System.Drawing.Color.White;
            this.LstSedes.FormattingEnabled = true;
            this.LstSedes.ItemHeight = 19;
            this.LstSedes.Location = new System.Drawing.Point(12, 238);
            this.LstSedes.Name = "LstSedes";
            this.LstSedes.Size = new System.Drawing.Size(428, 171);
            this.LstSedes.TabIndex = 17;
            this.LstSedes.SelectedIndexChanged += new System.EventHandler(this.LstSedes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(484, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "ID sede:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(471, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "ID cliente:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(553, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 1);
            this.panel3.TabIndex = 33;
            // 
            // TxtIdSede
            // 
            this.TxtIdSede.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtIdSede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdSede.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdSede.ForeColor = System.Drawing.Color.White;
            this.TxtIdSede.Location = new System.Drawing.Point(553, 165);
            this.TxtIdSede.Name = "TxtIdSede";
            this.TxtIdSede.Size = new System.Drawing.Size(252, 20);
            this.TxtIdSede.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(553, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 1);
            this.panel2.TabIndex = 31;
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdCliente.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCliente.ForeColor = System.Drawing.Color.White;
            this.TxtIdCliente.Location = new System.Drawing.Point(553, 115);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(252, 20);
            this.TxtIdCliente.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(553, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 29;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(715, 215);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(90, 37);
            this.BtnRegistrar.TabIndex = 28;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // DtpFecha
            // 
            this.DtpFecha.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(553, 71);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(122, 27);
            this.DtpFecha.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(496, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha:";
            // 
            // TxtIdAfiliacion
            // 
            this.TxtIdAfiliacion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtIdAfiliacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdAfiliacion.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdAfiliacion.ForeColor = System.Drawing.Color.White;
            this.TxtIdAfiliacion.Location = new System.Drawing.Point(553, 31);
            this.TxtIdAfiliacion.Name = "TxtIdAfiliacion";
            this.TxtIdAfiliacion.Size = new System.Drawing.Size(250, 20);
            this.TxtIdAfiliacion.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Afiliación:";
            // 
            // LblCampoVacios
            // 
            this.LblCampoVacios.AutoSize = true;
            this.LblCampoVacios.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampoVacios.ForeColor = System.Drawing.Color.Red;
            this.LblCampoVacios.Location = new System.Drawing.Point(550, 188);
            this.LblCampoVacios.Name = "LblCampoVacios";
            this.LblCampoVacios.Size = new System.Drawing.Size(11, 15);
            this.LblCampoVacios.TabIndex = 36;
            this.LblCampoVacios.Text = "-";
            this.LblCampoVacios.Visible = false;
            // 
            // RegistrarAfiliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(839, 433);
            this.Controls.Add(this.LblCampoVacios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtIdSede);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdAfiliacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstSedes);
            this.Controls.Add(this.LstClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarAfiliacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar afiliación";
            this.Load += new System.EventHandler(this.RegistrarAfiliacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LstClientes;
        private System.Windows.Forms.ListBox LstSedes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtIdSede;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdAfiliacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCampoVacios;
    }
}