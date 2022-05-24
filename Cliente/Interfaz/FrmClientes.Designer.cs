namespace ClienteFITUNED
{
    partial class FrmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.LblIngrese = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblConectado = new System.Windows.Forms.Label();
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PnlImagen = new System.Windows.Forms.Panel();
            this.PnlFituned = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlReservar = new System.Windows.Forms.Panel();
            this.CmbFechas = new System.Windows.Forms.ComboBox();
            this.BtnReservarFecha = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblIdCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbSedes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlConsultar = new System.Windows.Forms.Panel();
            this.DgvReservaciones = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlInferior = new System.Windows.Forms.Panel();
            this.BtnDesconectar = new System.Windows.Forms.Button();
            this.PnlInformacion = new System.Windows.Forms.Panel();
            this.LblNombreCompleto = new System.Windows.Forms.Label();
            this.BtnReservar = new System.Windows.Forms.Button();
            this.LblSusAfiliaciones = new System.Windows.Forms.Label();
            this.LstAfiliaciones = new System.Windows.Forms.ListBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.PnlSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlReservar.SuspendLayout();
            this.PnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservaciones)).BeginInit();
            this.PnlInferior.SuspendLayout();
            this.PnlInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblIngrese
            // 
            this.LblIngrese.AutoSize = true;
            this.LblIngrese.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngrese.ForeColor = System.Drawing.Color.White;
            this.LblIngrese.Location = new System.Drawing.Point(473, 4);
            this.LblIngrese.Name = "LblIngrese";
            this.LblIngrese.Size = new System.Drawing.Size(166, 19);
            this.LblIngrese.TabIndex = 0;
            this.LblIngrese.Text = "Ingrese su identificación";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.DarkGray;
            this.TxtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdentificacion.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.TxtIdentificacion.Location = new System.Drawing.Point(477, 32);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(164, 20);
            this.TxtIdentificacion.TabIndex = 1;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(648, 27);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(79, 28);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblConectado
            // 
            this.LblConectado.AutoSize = true;
            this.LblConectado.ForeColor = System.Drawing.Color.Black;
            this.LblConectado.Location = new System.Drawing.Point(474, 55);
            this.LblConectado.Name = "LblConectado";
            this.LblConectado.Size = new System.Drawing.Size(10, 13);
            this.LblConectado.TabIndex = 3;
            this.LblConectado.Text = "-";
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.DarkGray;
            this.PnlSuperior.Controls.Add(this.panel4);
            this.PnlSuperior.Controls.Add(this.PnlImagen);
            this.PnlSuperior.Controls.Add(this.PnlFituned);
            this.PnlSuperior.Controls.Add(this.TxtIdentificacion);
            this.PnlSuperior.Controls.Add(this.LblIngrese);
            this.PnlSuperior.Controls.Add(this.LblConectado);
            this.PnlSuperior.Controls.Add(this.BtnIngresar);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(739, 74);
            this.PnlSuperior.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(477, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 1);
            this.panel4.TabIndex = 13;
            // 
            // PnlImagen
            // 
            this.PnlImagen.BackgroundImage = global::ClienteFITUNED.Properties.Resources.dumbbell;
            this.PnlImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlImagen.Location = new System.Drawing.Point(10, 12);
            this.PnlImagen.Name = "PnlImagen";
            this.PnlImagen.Size = new System.Drawing.Size(50, 50);
            this.PnlImagen.TabIndex = 12;
            this.PnlImagen.Click += new System.EventHandler(this.PnlImagen_Click);
            // 
            // PnlFituned
            // 
            this.PnlFituned.AutoSize = true;
            this.PnlFituned.BackColor = System.Drawing.Color.Transparent;
            this.PnlFituned.Font = new System.Drawing.Font("Calibri Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlFituned.ForeColor = System.Drawing.Color.White;
            this.PnlFituned.Location = new System.Drawing.Point(66, 6);
            this.PnlFituned.Name = "PnlFituned";
            this.PnlFituned.Size = new System.Drawing.Size(196, 59);
            this.PnlFituned.TabIndex = 3;
            this.PnlFituned.Text = "FITUNED";
            this.PnlFituned.Click += new System.EventHandler(this.PnlFituned_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.PnlReservar);
            this.panel2.Controls.Add(this.PnlConsultar);
            this.panel2.Controls.Add(this.PnlInferior);
            this.panel2.Controls.Add(this.PnlInformacion);
            this.panel2.Controls.Add(this.LblBienvenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 450);
            this.panel2.TabIndex = 5;
            // 
            // PnlReservar
            // 
            this.PnlReservar.BackColor = System.Drawing.Color.DarkGray;
            this.PnlReservar.Controls.Add(this.CmbFechas);
            this.PnlReservar.Controls.Add(this.BtnReservarFecha);
            this.PnlReservar.Controls.Add(this.label5);
            this.PnlReservar.Controls.Add(this.LblIdCliente);
            this.PnlReservar.Controls.Add(this.label3);
            this.PnlReservar.Controls.Add(this.CmbSedes);
            this.PnlReservar.Controls.Add(this.label2);
            this.PnlReservar.Location = new System.Drawing.Point(10, 94);
            this.PnlReservar.Name = "PnlReservar";
            this.PnlReservar.Size = new System.Drawing.Size(100, 88);
            this.PnlReservar.TabIndex = 18;
            // 
            // CmbFechas
            // 
            this.CmbFechas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CmbFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbFechas.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFechas.ForeColor = System.Drawing.Color.White;
            this.CmbFechas.FormattingEnabled = true;
            this.CmbFechas.Location = new System.Drawing.Point(333, 157);
            this.CmbFechas.Name = "CmbFechas";
            this.CmbFechas.Size = new System.Drawing.Size(121, 27);
            this.CmbFechas.TabIndex = 18;
            // 
            // BtnReservarFecha
            // 
            this.BtnReservarFecha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnReservarFecha.FlatAppearance.BorderSize = 0;
            this.BtnReservarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservarFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservarFecha.ForeColor = System.Drawing.Color.White;
            this.BtnReservarFecha.Location = new System.Drawing.Point(333, 206);
            this.BtnReservarFecha.Name = "BtnReservarFecha";
            this.BtnReservarFecha.Size = new System.Drawing.Size(90, 37);
            this.BtnReservarFecha.TabIndex = 17;
            this.BtnReservarFecha.Text = "Reservar";
            this.BtnReservarFecha.UseVisualStyleBackColor = false;
            this.BtnReservarFecha.Click += new System.EventHandler(this.BtnReservarFecha_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(276, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha:";
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.AutoSize = true;
            this.LblIdCliente.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdCliente.ForeColor = System.Drawing.Color.White;
            this.LblIdCliente.Location = new System.Drawing.Point(329, 112);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(14, 19);
            this.LblIdCliente.TabIndex = 15;
            this.LblIdCliente.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(252, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID cliente:";
            // 
            // CmbSedes
            // 
            this.CmbSedes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CmbSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbSedes.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSedes.ForeColor = System.Drawing.Color.White;
            this.CmbSedes.FormattingEnabled = true;
            this.CmbSedes.Location = new System.Drawing.Point(333, 61);
            this.CmbSedes.Name = "CmbSedes";
            this.CmbSedes.Size = new System.Drawing.Size(121, 27);
            this.CmbSedes.TabIndex = 13;
            this.CmbSedes.SelectedValueChanged += new System.EventHandler(this.CmbSedes_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(283, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sede:";
            // 
            // PnlConsultar
            // 
            this.PnlConsultar.BackColor = System.Drawing.Color.DarkGray;
            this.PnlConsultar.Controls.Add(this.DgvReservaciones);
            this.PnlConsultar.Location = new System.Drawing.Point(115, 95);
            this.PnlConsultar.Name = "PnlConsultar";
            this.PnlConsultar.Size = new System.Drawing.Size(100, 87);
            this.PnlConsultar.TabIndex = 19;
            // 
            // DgvReservaciones
            // 
            this.DgvReservaciones.AllowUserToAddRows = false;
            this.DgvReservaciones.AllowUserToDeleteRows = false;
            this.DgvReservaciones.AllowUserToResizeColumns = false;
            this.DgvReservaciones.AllowUserToResizeRows = false;
            this.DgvReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReservaciones.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DgvReservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvReservaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReservaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.PrimerApellido,
            this.SegundoApellido,
            this.NombreSede,
            this.IdReservacion,
            this.Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReservaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvReservaciones.GridColor = System.Drawing.Color.White;
            this.DgvReservaciones.Location = new System.Drawing.Point(3, 3);
            this.DgvReservaciones.MultiSelect = false;
            this.DgvReservaciones.Name = "DgvReservaciones";
            this.DgvReservaciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReservaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvReservaciones.RowHeadersVisible = false;
            this.DgvReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReservaciones.Size = new System.Drawing.Size(635, 292);
            this.DgvReservaciones.TabIndex = 0;
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
            // NombreSede
            // 
            this.NombreSede.HeaderText = "Nombre de la sede";
            this.NombreSede.Name = "NombreSede";
            this.NombreSede.ReadOnly = true;
            // 
            // IdReservacion
            // 
            this.IdReservacion.HeaderText = "ID reservación";
            this.IdReservacion.Name = "IdReservacion";
            this.IdReservacion.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // PnlInferior
            // 
            this.PnlInferior.Controls.Add(this.BtnDesconectar);
            this.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlInferior.Location = new System.Drawing.Point(0, 398);
            this.PnlInferior.Name = "PnlInferior";
            this.PnlInferior.Size = new System.Drawing.Size(739, 52);
            this.PnlInferior.TabIndex = 17;
            // 
            // BtnDesconectar
            // 
            this.BtnDesconectar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDesconectar.FlatAppearance.BorderSize = 0;
            this.BtnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesconectar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesconectar.ForeColor = System.Drawing.Color.White;
            this.BtnDesconectar.Location = new System.Drawing.Point(610, 12);
            this.BtnDesconectar.Name = "BtnDesconectar";
            this.BtnDesconectar.Size = new System.Drawing.Size(117, 28);
            this.BtnDesconectar.TabIndex = 11;
            this.BtnDesconectar.Text = "Desconectarse";
            this.BtnDesconectar.UseVisualStyleBackColor = false;
            this.BtnDesconectar.Click += new System.EventHandler(this.BtnDesconectar_Click);
            // 
            // PnlInformacion
            // 
            this.PnlInformacion.Controls.Add(this.LblNombreCompleto);
            this.PnlInformacion.Controls.Add(this.BtnReservar);
            this.PnlInformacion.Controls.Add(this.LblSusAfiliaciones);
            this.PnlInformacion.Controls.Add(this.LstAfiliaciones);
            this.PnlInformacion.Controls.Add(this.BtnConsultar);
            this.PnlInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlInformacion.Location = new System.Drawing.Point(0, 0);
            this.PnlInformacion.Name = "PnlInformacion";
            this.PnlInformacion.Size = new System.Drawing.Size(739, 88);
            this.PnlInformacion.TabIndex = 16;
            // 
            // LblNombreCompleto
            // 
            this.LblNombreCompleto.AutoSize = true;
            this.LblNombreCompleto.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCompleto.ForeColor = System.Drawing.Color.White;
            this.LblNombreCompleto.Location = new System.Drawing.Point(3, 0);
            this.LblNombreCompleto.Name = "LblNombreCompleto";
            this.LblNombreCompleto.Size = new System.Drawing.Size(132, 42);
            this.LblNombreCompleto.TabIndex = 6;
            this.LblNombreCompleto.Text = "Nombre";
            // 
            // BtnReservar
            // 
            this.BtnReservar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnReservar.FlatAppearance.BorderSize = 0;
            this.BtnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservar.ForeColor = System.Drawing.Color.White;
            this.BtnReservar.Location = new System.Drawing.Point(10, 45);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Size = new System.Drawing.Size(100, 43);
            this.BtnReservar.TabIndex = 4;
            this.BtnReservar.Text = "Reservar";
            this.BtnReservar.UseVisualStyleBackColor = false;
            this.BtnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // LblSusAfiliaciones
            // 
            this.LblSusAfiliaciones.AutoSize = true;
            this.LblSusAfiliaciones.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSusAfiliaciones.ForeColor = System.Drawing.Color.White;
            this.LblSusAfiliaciones.Location = new System.Drawing.Point(591, 3);
            this.LblSusAfiliaciones.Name = "LblSusAfiliaciones";
            this.LblSusAfiliaciones.Size = new System.Drawing.Size(107, 19);
            this.LblSusAfiliaciones.TabIndex = 14;
            this.LblSusAfiliaciones.Text = "Sus afiliaciones";
            // 
            // LstAfiliaciones
            // 
            this.LstAfiliaciones.BackColor = System.Drawing.Color.DarkGray;
            this.LstAfiliaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstAfiliaciones.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstAfiliaciones.ForeColor = System.Drawing.Color.White;
            this.LstAfiliaciones.FormattingEnabled = true;
            this.LstAfiliaciones.ItemHeight = 19;
            this.LstAfiliaciones.Location = new System.Drawing.Point(595, 25);
            this.LstAfiliaciones.Name = "LstAfiliaciones";
            this.LstAfiliaciones.Size = new System.Drawing.Size(132, 57);
            this.LstAfiliaciones.TabIndex = 9;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.Color.White;
            this.BtnConsultar.Location = new System.Drawing.Point(115, 45);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(179, 43);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar reservaciones";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.Font = new System.Drawing.Font("Calibri Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.ForeColor = System.Drawing.Color.White;
            this.LblBienvenido.Location = new System.Drawing.Point(400, 353);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(327, 36);
            this.LblBienvenido.TabIndex = 15;
            this.LblBienvenido.Text = "¡Bienvenido(a) a FITUNED!";
            this.LblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(739, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FITUNED";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCliente_FormClosing);
            this.PnlSuperior.ResumeLayout(false);
            this.PnlSuperior.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PnlReservar.ResumeLayout(false);
            this.PnlReservar.PerformLayout();
            this.PnlConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservaciones)).EndInit();
            this.PnlInferior.ResumeLayout(false);
            this.PnlInformacion.ResumeLayout(false);
            this.PnlInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblIngrese;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblConectado;
        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Label PnlFituned;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnReservar;
        private System.Windows.Forms.Label LblNombreCompleto;
        private System.Windows.Forms.ListBox LstAfiliaciones;
        private System.Windows.Forms.Button BtnDesconectar;
        private System.Windows.Forms.Panel PnlImagen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblSusAfiliaciones;
        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.Panel PnlInformacion;
        private System.Windows.Forms.Panel PnlInferior;
        private System.Windows.Forms.Panel PnlReservar;
        private System.Windows.Forms.ComboBox CmbFechas;
        private System.Windows.Forms.Button BtnReservarFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbSedes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlConsultar;
        private System.Windows.Forms.DataGridView DgvReservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}

