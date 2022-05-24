namespace ServidorFITUNED.Interfaz.CuposSedes
{
    partial class FrmRegistrarCupos
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
            this.CmbSedes = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCupos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCamposVacios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbSedes
            // 
            this.CmbSedes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CmbSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbSedes.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSedes.ForeColor = System.Drawing.Color.White;
            this.CmbSedes.FormattingEnabled = true;
            this.CmbSedes.Location = new System.Drawing.Point(158, 59);
            this.CmbSedes.Name = "CmbSedes";
            this.CmbSedes.Size = new System.Drawing.Size(116, 27);
            this.CmbSedes.TabIndex = 2;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(158, 115);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(116, 27);
            this.DtpFecha.TabIndex = 3;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(184, 216);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(90, 37);
            this.BtnRegistrar.TabIndex = 6;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(158, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 1);
            this.panel1.TabIndex = 16;
            // 
            // TxtCupos
            // 
            this.TxtCupos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtCupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCupos.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCupos.ForeColor = System.Drawing.Color.White;
            this.TxtCupos.Location = new System.Drawing.Point(158, 171);
            this.TxtCupos.Name = "TxtCupos";
            this.TxtCupos.Size = new System.Drawing.Size(116, 20);
            this.TxtCupos.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cupos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(101, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sede:";
            // 
            // LblCamposVacios
            // 
            this.LblCamposVacios.AutoSize = true;
            this.LblCamposVacios.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCamposVacios.ForeColor = System.Drawing.Color.Red;
            this.LblCamposVacios.Location = new System.Drawing.Point(100, 192);
            this.LblCamposVacios.Name = "LblCamposVacios";
            this.LblCamposVacios.Size = new System.Drawing.Size(11, 15);
            this.LblCamposVacios.TabIndex = 19;
            this.LblCamposVacios.Text = "-";
            // 
            // RegistrarCupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(384, 309);
            this.Controls.Add(this.LblCamposVacios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtCupos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.CmbSedes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarCupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar cupos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbSedes;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCupos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCamposVacios;
    }
}