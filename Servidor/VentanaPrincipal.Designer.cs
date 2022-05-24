namespace ServidorFITUNED
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuSedes = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcConsultarSedes = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcRegistrarSedes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcConsultarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcRegistrarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSedesCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcConsultarSedesCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcRegistrarSedesCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCuposSede = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcConsultarCuposSede = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcRegistrarCuposSede = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnDetener = new System.Windows.Forms.Button();
            this.TxtBitacora = new System.Windows.Forms.TextBox();
            this.LblC = new System.Windows.Forms.Label();
            this.LblConectados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.AutoSize = false;
            this.MenuPrincipal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSedes,
            this.MenuClientes,
            this.MenuSedesCliente,
            this.MenuCuposSede});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(784, 36);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuSedes
            // 
            this.MenuSedes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuSedes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcConsultarSedes,
            this.OpcRegistrarSedes});
            this.MenuSedes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuSedes.Name = "MenuSedes";
            this.MenuSedes.Size = new System.Drawing.Size(60, 32);
            this.MenuSedes.Text = "Sedes";
            // 
            // OpcConsultarSedes
            // 
            this.OpcConsultarSedes.BackColor = System.Drawing.SystemColors.Control;
            this.OpcConsultarSedes.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcConsultarSedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpcConsultarSedes.Name = "OpcConsultarSedes";
            this.OpcConsultarSedes.Size = new System.Drawing.Size(140, 24);
            this.OpcConsultarSedes.Text = "Consultar";
            this.OpcConsultarSedes.Click += new System.EventHandler(this.OpcConsultarSedes_Click);
            // 
            // OpcRegistrarSedes
            // 
            this.OpcRegistrarSedes.BackColor = System.Drawing.SystemColors.Control;
            this.OpcRegistrarSedes.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcRegistrarSedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpcRegistrarSedes.Name = "OpcRegistrarSedes";
            this.OpcRegistrarSedes.Size = new System.Drawing.Size(140, 24);
            this.OpcRegistrarSedes.Text = "Registrar";
            this.OpcRegistrarSedes.Click += new System.EventHandler(this.OpcRegistrarSedes_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcConsultarClientes,
            this.OpcRegistrarClientes});
            this.MenuClientes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(74, 32);
            this.MenuClientes.Text = "Clientes";
            // 
            // OpcConsultarClientes
            // 
            this.OpcConsultarClientes.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcConsultarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpcConsultarClientes.Name = "OpcConsultarClientes";
            this.OpcConsultarClientes.Size = new System.Drawing.Size(140, 24);
            this.OpcConsultarClientes.Text = "Consultar";
            this.OpcConsultarClientes.Click += new System.EventHandler(this.OpcConsultarClientes_Click);
            // 
            // OpcRegistrarClientes
            // 
            this.OpcRegistrarClientes.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcRegistrarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpcRegistrarClientes.Name = "OpcRegistrarClientes";
            this.OpcRegistrarClientes.Size = new System.Drawing.Size(140, 24);
            this.OpcRegistrarClientes.Text = "Registrar";
            this.OpcRegistrarClientes.Click += new System.EventHandler(this.OpcRegistrarClientes_Click);
            // 
            // MenuSedesCliente
            // 
            this.MenuSedesCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcConsultarSedesCliente,
            this.OpcRegistrarSedesCliente});
            this.MenuSedesCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSedesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuSedesCliente.Name = "MenuSedesCliente";
            this.MenuSedesCliente.Size = new System.Drawing.Size(131, 32);
            this.MenuSedesCliente.Text = "Sedes de cliente";
            // 
            // OpcConsultarSedesCliente
            // 
            this.OpcConsultarSedesCliente.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcConsultarSedesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpcConsultarSedesCliente.Name = "OpcConsultarSedesCliente";
            this.OpcConsultarSedesCliente.Size = new System.Drawing.Size(140, 24);
            this.OpcConsultarSedesCliente.Text = "Consultar";
            this.OpcConsultarSedesCliente.Click += new System.EventHandler(this.OpcConsultarSedesCliente_Click);
            // 
            // OpcRegistrarSedesCliente
            // 
            this.OpcRegistrarSedesCliente.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcRegistrarSedesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpcRegistrarSedesCliente.Name = "OpcRegistrarSedesCliente";
            this.OpcRegistrarSedesCliente.Size = new System.Drawing.Size(140, 24);
            this.OpcRegistrarSedesCliente.Text = "Registrar";
            this.OpcRegistrarSedesCliente.Click += new System.EventHandler(this.OpcRegistrarSedesCliente_Click);
            // 
            // MenuCuposSede
            // 
            this.MenuCuposSede.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcConsultarCuposSede,
            this.OpcRegistrarCuposSede});
            this.MenuCuposSede.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCuposSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuCuposSede.Name = "MenuCuposSede";
            this.MenuCuposSede.Size = new System.Drawing.Size(125, 32);
            this.MenuCuposSede.Text = "Cupos por sede";
            // 
            // OpcConsultarCuposSede
            // 
            this.OpcConsultarCuposSede.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcConsultarCuposSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpcConsultarCuposSede.Name = "OpcConsultarCuposSede";
            this.OpcConsultarCuposSede.Size = new System.Drawing.Size(140, 24);
            this.OpcConsultarCuposSede.Text = "Consultar";
            this.OpcConsultarCuposSede.Click += new System.EventHandler(this.OpcConsultarCuposSede_Click);
            // 
            // OpcRegistrarCuposSede
            // 
            this.OpcRegistrarCuposSede.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcRegistrarCuposSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpcRegistrarCuposSede.Name = "OpcRegistrarCuposSede";
            this.OpcRegistrarCuposSede.Size = new System.Drawing.Size(140, 24);
            this.OpcRegistrarCuposSede.Text = "Registrar";
            this.OpcRegistrarCuposSede.Click += new System.EventHandler(this.OpcRegistrarCuposSede_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.White;
            this.BtnIniciar.Location = new System.Drawing.Point(12, 515);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(120, 34);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar servidor";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnDetener
            // 
            this.BtnDetener.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnDetener.FlatAppearance.BorderSize = 0;
            this.BtnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetener.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetener.ForeColor = System.Drawing.Color.White;
            this.BtnDetener.Location = new System.Drawing.Point(138, 515);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(133, 34);
            this.BtnDetener.TabIndex = 3;
            this.BtnDetener.Text = "Detener servidor";
            this.BtnDetener.UseVisualStyleBackColor = false;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // TxtBitacora
            // 
            this.TxtBitacora.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBitacora.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBitacora.Location = new System.Drawing.Point(12, 56);
            this.TxtBitacora.Multiline = true;
            this.TxtBitacora.Name = "TxtBitacora";
            this.TxtBitacora.ReadOnly = true;
            this.TxtBitacora.Size = new System.Drawing.Size(760, 453);
            this.TxtBitacora.TabIndex = 2;
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblC.ForeColor = System.Drawing.Color.White;
            this.LblC.Location = new System.Drawing.Point(277, 520);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(210, 29);
            this.LblC.TabIndex = 4;
            this.LblC.Text = "Clientes conectados:";
            // 
            // LblConectados
            // 
            this.LblConectados.AutoSize = true;
            this.LblConectados.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConectados.ForeColor = System.Drawing.Color.White;
            this.LblConectados.Location = new System.Drawing.Point(483, 520);
            this.LblConectados.Name = "LblConectados";
            this.LblConectados.Size = new System.Drawing.Size(25, 29);
            this.LblConectados.TabIndex = 5;
            this.LblConectados.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::ServidorFITUNED.Properties.Resources.dumbbell;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(710, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 6;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblConectados);
            this.Controls.Add(this.LblC);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.TxtBitacora);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.MenuPrincipal);
            this.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor FITUNED";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuSedes;
        private System.Windows.Forms.ToolStripMenuItem OpcConsultarSedes;
        private System.Windows.Forms.ToolStripMenuItem OpcRegistrarSedes;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem OpcConsultarClientes;
        private System.Windows.Forms.ToolStripMenuItem OpcRegistrarClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuSedesCliente;
        private System.Windows.Forms.ToolStripMenuItem OpcConsultarSedesCliente;
        private System.Windows.Forms.ToolStripMenuItem OpcRegistrarSedesCliente;
        private System.Windows.Forms.ToolStripMenuItem MenuCuposSede;
        private System.Windows.Forms.ToolStripMenuItem OpcConsultarCuposSede;
        private System.Windows.Forms.ToolStripMenuItem OpcRegistrarCuposSede;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnDetener;
        private System.Windows.Forms.TextBox TxtBitacora;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblConectados;
        private System.Windows.Forms.Panel panel1;
    }
}

