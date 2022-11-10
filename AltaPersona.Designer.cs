namespace proyecto_base
{
    partial class AltaPersona
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdOtro = new System.Windows.Forms.RadioButton();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.lblNumeroCasa = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.chkSoltero = new System.Windows.Forms.CheckBox();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.chkHijos = new System.Windows.Forms.CheckBox();
            this.lblCantidadHijos = new System.Windows.Forms.Label();
            this.txtCantidadHijos = new System.Windows.Forms.MaskedTextBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblCarerra = new System.Windows.Forms.Label();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gdrPersonas = new System.Windows.Forms.DataGridView();
            this.btnActualizarPersona = new System.Windows.Forms.Button();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(47, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(148, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(198, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(45, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(238, 107);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(108, 20);
            this.txtFechaNacimiento.TabIndex = 4;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(49, 107);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(183, 20);
            this.lblNacimiento.TabIndex = 5;
            this.lblNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(49, 146);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 20);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdOtro);
            this.panel1.Controls.Add(this.rdFemenino);
            this.panel1.Controls.Add(this.rdMasculino);
            this.panel1.Location = new System.Drawing.Point(109, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 83);
            this.panel1.TabIndex = 7;
            // 
            // rdOtro
            // 
            this.rdOtro.AutoSize = true;
            this.rdOtro.Location = new System.Drawing.Point(39, 50);
            this.rdOtro.Name = "rdOtro";
            this.rdOtro.Size = new System.Drawing.Size(45, 17);
            this.rdOtro.TabIndex = 2;
            this.rdOtro.TabStop = true;
            this.rdOtro.Text = "Otro";
            this.rdOtro.UseVisualStyleBackColor = true;
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Location = new System.Drawing.Point(39, 27);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdFemenino.TabIndex = 1;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Location = new System.Drawing.Point(39, 4);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdMasculino.TabIndex = 0;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(49, 234);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(145, 20);
            this.lblTipoDocumento.TabIndex = 8;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(200, 233);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(146, 21);
            this.cmbTipoDocumento.TabIndex = 9;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(49, 264);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(129, 20);
            this.lblNumeroDocumento.TabIndex = 10;
            this.lblNumeroDocumento.Text = "N° Documento:";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(200, 266);
            this.txtNumeroDocumento.Mask = "99999999";
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDocumento.TabIndex = 11;
            this.txtNumeroDocumento.ValidatingType = typeof(int);
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(151, 339);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(198, 20);
            this.txtNumeroCasa.TabIndex = 15;
            // 
            // lblNumeroCasa
            // 
            this.lblNumeroCasa.AutoSize = true;
            this.lblNumeroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCasa.Location = new System.Drawing.Point(67, 339);
            this.lblNumeroCasa.Name = "lblNumeroCasa";
            this.lblNumeroCasa.Size = new System.Drawing.Size(75, 20);
            this.lblNumeroCasa.TabIndex = 14;
            this.lblNumeroCasa.Text = "N° casa:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(151, 302);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(198, 20);
            this.txtCalle.TabIndex = 13;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(88, 300);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(54, 20);
            this.lblCalle.TabIndex = 12;
            this.lblCalle.Text = "Calle:";
            // 
            // chkSoltero
            // 
            this.chkSoltero.AutoSize = true;
            this.chkSoltero.Location = new System.Drawing.Point(196, 381);
            this.chkSoltero.Name = "chkSoltero";
            this.chkSoltero.Size = new System.Drawing.Size(72, 17);
            this.chkSoltero.TabIndex = 16;
            this.chkSoltero.Text = "Solteroski";
            this.chkSoltero.UseVisualStyleBackColor = true;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(196, 405);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(72, 17);
            this.chkCasado.TabIndex = 17;
            this.chkCasado.Text = "Con anillo";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // chkHijos
            // 
            this.chkHijos.AutoSize = true;
            this.chkHijos.Location = new System.Drawing.Point(196, 429);
            this.chkHijos.Name = "chkHijos";
            this.chkHijos.Size = new System.Drawing.Size(79, 17);
            this.chkHijos.TabIndex = 18;
            this.chkHijos.Text = "Con bendis";
            this.chkHijos.UseVisualStyleBackColor = true;
            this.chkHijos.CheckedChanged += new System.EventHandler(this.chkHijos_CheckedChanged);
            // 
            // lblCantidadHijos
            // 
            this.lblCantidadHijos.AutoSize = true;
            this.lblCantidadHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadHijos.Location = new System.Drawing.Point(280, 430);
            this.lblCantidadHijos.Name = "lblCantidadHijos";
            this.lblCantidadHijos.Size = new System.Drawing.Size(55, 13);
            this.lblCantidadHijos.TabIndex = 19;
            this.lblCantidadHijos.Text = "Cantidad: ";
            // 
            // txtCantidadHijos
            // 
            this.txtCantidadHijos.Location = new System.Drawing.Point(331, 427);
            this.txtCantidadHijos.Mask = "99";
            this.txtCantidadHijos.Name = "txtCantidadHijos";
            this.txtCantidadHijos.Size = new System.Drawing.Size(30, 20);
            this.txtCantidadHijos.TabIndex = 20;
            this.txtCantidadHijos.ValidatingType = typeof(int);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(151, 464);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(146, 21);
            this.cmbCarrera.TabIndex = 22;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(52, 462);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(0, 20);
            this.lblCarrera.TabIndex = 21;
            // 
            // lblCarerra
            // 
            this.lblCarerra.AutoSize = true;
            this.lblCarerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarerra.Location = new System.Drawing.Point(68, 462);
            this.lblCarerra.Name = "lblCarerra";
            this.lblCarerra.Size = new System.Drawing.Size(74, 20);
            this.lblCarerra.TabIndex = 23;
            this.lblCarerra.Text = "Carrera:";
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPersona.Location = new System.Drawing.Point(372, 367);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(98, 54);
            this.btnGuardarPersona.TabIndex = 24;
            this.btnGuardarPersona.Text = "Guardar Persona";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            this.btnGuardarPersona.Click += new System.EventHandler(this.btnGuardarPersona_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(372, 440);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 54);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Alta de Nueva Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Datos adicionales:";
            // 
            // gdrPersonas
            // 
            this.gdrPersonas.AllowUserToAddRows = false;
            this.gdrPersonas.AllowUserToDeleteRows = false;
            this.gdrPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.Documento,
            this.Nombre,
            this.Apellido});
            this.gdrPersonas.Location = new System.Drawing.Point(372, 26);
            this.gdrPersonas.Name = "gdrPersonas";
            this.gdrPersonas.ReadOnly = true;
            this.gdrPersonas.Size = new System.Drawing.Size(561, 296);
            this.gdrPersonas.TabIndex = 28;
            this.gdrPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrPersonas_CellClick);
            // 
            // btnActualizarPersona
            // 
            this.btnActualizarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPersona.Location = new System.Drawing.Point(489, 389);
            this.btnActualizarPersona.Name = "btnActualizarPersona";
            this.btnActualizarPersona.Size = new System.Drawing.Size(98, 54);
            this.btnActualizarPersona.TabIndex = 29;
            this.btnActualizarPersona.Text = "Actualizar Persona";
            this.btnActualizarPersona.UseVisualStyleBackColor = true;
            this.btnActualizarPersona.Click += new System.EventHandler(this.btnActualizarPersona_Click);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "IdTipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo doc";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 40;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "NroDocumento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apelido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 250;
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 506);
            this.Controls.Add(this.btnActualizarPersona);
            this.Controls.Add(this.gdrPersonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardarPersona);
            this.Controls.Add(this.lblCarerra);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtCantidadHijos);
            this.Controls.Add(this.lblCantidadHijos);
            this.Controls.Add(this.chkHijos);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.chkSoltero);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(this.lblNumeroCasa);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "AltaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Nueva Persona";
            this.Load += new System.EventHandler(this.AltaPersona_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdOtro;
        private System.Windows.Forms.RadioButton rdFemenino;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.MaskedTextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.Label lblNumeroCasa;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.CheckBox chkSoltero;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.CheckBox chkHijos;
        private System.Windows.Forms.Label lblCantidadHijos;
        private System.Windows.Forms.MaskedTextBox txtCantidadHijos;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblCarerra;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gdrPersonas;
        private System.Windows.Forms.Button btnActualizarPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}